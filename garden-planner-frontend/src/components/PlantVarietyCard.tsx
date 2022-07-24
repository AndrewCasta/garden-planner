import { useState } from 'react';
import { styled } from '@mui/material/styles';
import Card from '@mui/material/Card';
import CardMedia from '@mui/material/CardMedia';
import CardContent from '@mui/material/CardContent';
import CardActions from '@mui/material/CardActions';
import Collapse from '@mui/material/Collapse';
import IconButton, { IconButtonProps } from '@mui/material/IconButton';
import Typography from '@mui/material/Typography';
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';
import WbSunnyIcon from '@mui/icons-material/WbSunny';
import OpacityIcon from '@mui/icons-material/Opacity';
import Icon from '@mui/material/Icon';
import Stack from '@mui/material/Stack';
import FormGroup from '@mui/material/FormGroup';
import FormControlLabel from '@mui/material/FormControlLabel';
import Checkbox from '@mui/material/Checkbox';

const apiUrl = 'https://localhost:7104';
const cropId = 1;

interface ExpandMoreProps extends IconButtonProps {
  expand: boolean;
}

const ExpandMore = styled((props: ExpandMoreProps) => {
  const { expand, ...other } = props;
  return <IconButton {...other} />;
})(({ theme, expand }) => ({
  transform: !expand ? 'rotate(0deg)' : 'rotate(180deg)',
  marginLeft: 'auto',
  transition: theme.transitions.create('transform', {
    duration: theme.transitions.duration.shortest,
  }),
}));

export default function PlantVarietyCard(props: any) {
  const { id, name, image, description, sun, water, lifecycle } = props;
  const seasons = [];
  for (const prop in props) {
    if (prop === 'spring' && props[prop]) seasons.push(prop);
    if (prop === 'summer' && props[prop]) seasons.push(prop);
    if (prop === 'autum' && props[prop]) seasons.push(prop);
    if (prop === 'winter' && props[prop]) seasons.push(prop);
  }
  const [selected, setSelected] = useState<boolean>(props.selected);
  const [expanded, setExpanded] = useState(false);

  const postCropVariety = async () => {
    const data = { plantVarietyID: id, cropID: cropId };
    const response = await fetch(`${apiUrl}/plant-varieties/crop`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(data),
    });
    console.log(response);
  };

  const deleteCropVariety = async () => {
    const response = await fetch(
      `${apiUrl}/plant-varieties/${id}/crop/${cropId}`,
      {
        method: 'DELETE',
      }
    );
    console.log(response);
  };

  const handleSelectClick = () => {
    if (!selected) postCropVariety();
    if (selected) deleteCropVariety();
    setSelected(!selected);
  };

  const handleExpandClick = () => {
    setExpanded(!expanded);
  };

  return (
    <Card sx={{ width: 230, height: '100%' }}>
      <CardMedia
        component='img'
        height='194'
        src={`/images/plant-icons/${image}`}
        alt='{name}'
      />
      <CardContent>
        <Typography gutterBottom variant='h5' component='div'>
          {name}
        </Typography>
        <Stack direction='row' spacing={1} alignItems='center'>
          <Icon>
            <WbSunnyIcon />
          </Icon>
          <Typography variant='body1'>{sun}</Typography>
          <Icon>
            <OpacityIcon />
          </Icon>
          <Typography variant='body1'>{water}</Typography>
        </Stack>
      </CardContent>
      <CardActions>
        <FormGroup>
          <FormControlLabel
            control={
              <Checkbox checked={selected} onClick={handleSelectClick} />
            }
            label='Plant'
          />
        </FormGroup>
        <ExpandMore
          expand={expanded}
          onClick={handleExpandClick}
          aria-expanded={expanded}
          aria-label='show more'>
          <ExpandMoreIcon />
        </ExpandMore>
      </CardActions>
      <Collapse in={expanded} timeout='auto' unmountOnExit>
        <CardContent>
          <Typography variant='h6' gutterBottom component='div'>
            Description
          </Typography>
          <Typography paragraph>{description}</Typography>
          <Typography variant='body2' gutterBottom>
            <strong>Lifecycle: </strong>
            {lifecycle}
          </Typography>
          <Typography variant='body2' gutterBottom>
            <strong>Planting: </strong>
            {`${seasons.join(', ')}`}
          </Typography>
        </CardContent>
      </Collapse>
    </Card>
  );
}
