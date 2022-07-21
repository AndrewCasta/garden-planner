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
  const { name, image, description, sun, water, lifecycle } = props;
  const seasons = [];
  for (const prop in props) {
    if (prop === 'spring' && props[prop]) seasons.push(prop);
    if (prop === 'summer' && props[prop]) seasons.push(prop);
    if (prop === 'autum' && props[prop]) seasons.push(prop);
    if (prop === 'winter' && props[prop]) seasons.push(prop);
  }

  const [expanded, setExpanded] = useState(false);

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
        <Typography variant='h5' component='div'>
          {name}
        </Typography>
      </CardContent>
      <CardActions>
        <Icon>
          <WbSunnyIcon />
        </Icon>
        {sun}
        <Icon>
          <OpacityIcon />
        </Icon>
        {water}
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
