import { useEffect, useState } from 'react';
import Box from '@mui/material/Box';
import List from '@mui/material/List';
import Typography from '@mui/material/Typography';
import ListItem from '@mui/material/ListItem';
import ListItemButton from '@mui/material/ListItemButton';
import ListItemText from '@mui/material/ListItemText';
import DeleteOutlineIcon from '@mui/icons-material/DeleteOutline';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import IconButton from '@mui/material/IconButton';
import { useStore } from '../store';
import Dialog from '@mui/material/Dialog';
import DialogTitle from '@mui/material/DialogTitle';
import DialogContent from '@mui/material/DialogContent';
import DialogContentText from '@mui/material/DialogContentText';
import DialogActions from '@mui/material/DialogActions';
import ApiURL from '../utils/ApiURL';

export default function NavLinks() {
  const [crops, setCrops] = useState<any[]>([]);
  const setSelectedCrop = useStore(state => state.setCrop);
  const selectedCropId = useStore(state => state.crop.id);
  const [isAddingCrop, setIsAddingCrop] = useState<boolean>(false);
  const [newCropName, setNewCropName] = useState('');
  const [isDeleting, setIsDeleting] = useState(false);

  const fetchCrops = async () => {
    const response = await fetch(`${ApiURL}/crops`);
    const data = await response.json();
    setCrops(data);
  };

  const postCrop = async (cropName: string) => {
    const data = { name: cropName };
    const response = await fetch(`${ApiURL}/crop`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(data),
    });
    const crop = await response.json();
    return crop;
  };

  const deleteCrop = async (id: number) => {
    const response = await fetch(`${ApiURL}/crop/${id}`, {
      method: 'DELETE',
    });
    return response;
  };

  useEffect(() => {
    fetchCrops();
  }, []);

  const handleNewCropSubmit = async (e: any) => {
    e.preventDefault();
    const newCrop = await postCrop(newCropName);
    setCrops([...crops, newCrop]);
    setSelectedCrop({ id: newCrop.id, name: newCrop.name });
    setIsAddingCrop(false);
    setNewCropName('');
  };

  const handleCropDelete = async (id: number) => {
    deleteCrop(id);
    const cropIndex = crops.findIndex(crop => crop.id === id);
    crops.splice(cropIndex, 1);
    setCrops(crops);
    setSelectedCrop({ id: 0, name: 'No crop selected' });
    setIsDeleting(false);
  };

  return (
    <Box sx={{ overflow: 'auto' }}>
      <Typography
        sx={{ padding: 1, paddingTop: 4 }}
        variant='h5'
        component='div'>
        Select crop:
      </Typography>
      <List>
        {crops.map((crop, index) => (
          <ListItem key={crop.id} disablePadding>
            <ListItemButton
              selected={selectedCropId === crop.id}
              onClick={() => setSelectedCrop({ id: crop.id, name: crop.name })}>
              <ListItemText primary={crop.name} />
            </ListItemButton>
            <IconButton onClick={() => setIsDeleting(true)}>
              <DeleteOutlineIcon fontSize='small' />
            </IconButton>
            <Dialog open={isDeleting} onClose={() => setIsDeleting(false)}>
              <DialogTitle id='alert-dialog-title'>
                {'Delete Crop?'}
              </DialogTitle>
              <DialogContent>
                <DialogContentText id='alert-dialog-description'>
                  This will permanently delete this crop and any changes will be
                  lost.
                </DialogContentText>
              </DialogContent>
              <DialogActions>
                <Button onClick={() => setIsDeleting(false)}>Keep</Button>
                <Button
                  onClick={() => handleCropDelete(crop.id)}
                  color='error'
                  autoFocus>
                  Delete
                </Button>
              </DialogActions>
            </Dialog>
          </ListItem>
        ))}
        {!isAddingCrop && (
          <ListItem>
            <Button
              variant='outlined'
              size='small'
              onClick={() => setIsAddingCrop(true)}>
              Add
            </Button>
          </ListItem>
        )}
        {isAddingCrop && (
          <ListItem>
            <form onSubmit={handleNewCropSubmit}>
              <TextField
                id='standard-basic'
                label='Crop Name'
                variant='standard'
                value={newCropName}
                onChange={e => setNewCropName(e.target.value)}
              />
            </form>
          </ListItem>
        )}
      </List>
    </Box>
  );
}
