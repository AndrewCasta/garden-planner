import { useState, useEffect } from 'react';
import Stack from '@mui/material/Stack';
import PlantCard from './PlantCard';
import PlantVarietyCard from './PlantVarietyCard';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import { useStore } from '../store';

const apiUrl = 'https://localhost:7104';

export default function CropPlants() {
  const [plantVarieties, setPlantVarieties] = useState<any[]>([]);
  const [cropVarieties, setCropVarieties] = useState<any[]>([]);
  const [expanded, setExpanded] = useState(false);
  const cropId = useStore(state => state.crop.id);

  const fetchPlants = async () => {
    const response = await fetch(`${apiUrl}/plant-varieties`);
    const data = await response.json();
    setPlantVarieties(data);
  };
  const fetchCropVarieties = async () => {
    const response = await fetch(`${apiUrl}/plant-varieties/crop/${cropId}`);
    const data = await response.json();
    setCropVarieties(data);
  };

  useEffect(() => {
    fetchPlants();
    fetchCropVarieties();
  }, [cropId]);

  const handleExpandClick = () => {
    fetchCropVarieties();
    setExpanded(!expanded);
  };

  return (
    <Box
      sx={{
        backgroundColor: '#f5f5f5',
        padding: '1rem 2rem',
      }}>
      <Stack paddingBottom={2} direction='row' justifyContent='space-between'>
        <Typography variant='h5' component='div'>
          Plant Varieties:
        </Typography>
        <Button
          onClick={handleExpandClick}
          variant={expanded ? 'contained' : 'outlined'}>
          {expanded ? 'Done' : 'Edit'}
        </Button>
      </Stack>
      {expanded && (
        <Box
          sx={{
            display: 'flex',
            flexDirection: 'row',
            flexWrap: 'wrap',
            gap: '20px',
          }}>
          {plantVarieties.map(plant => {
            const selected = cropVarieties.includes(plant.id);
            return (
              <PlantVarietyCard key={plant.id} selected={selected} {...plant} />
            );
          })}
        </Box>
      )}
      {!expanded && (
        <Box
          sx={{
            display: 'flex',
            flexDirection: 'row',
            flexWrap: 'wrap',
            gap: '20px',
            maxHeight: '150px',
            overflowY: 'scroll',
          }}>
          {plantVarieties.map(plant => {
            if (cropVarieties.includes(plant.id)) {
              return <PlantCard key={plant.id} {...plant} />;
            }
            return null;
          })}
        </Box>
      )}
    </Box>
  );
}
