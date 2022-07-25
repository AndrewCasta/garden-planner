import Typography from '@mui/material/Typography';
import React from 'react';
import CropPlants from './CropPlants';
import { useStore } from '../store';

export default function PlanningArea() {
  const crop = useStore(state => state.crop);

  return (
    <>
      <Typography gutterBottom variant='h2' component='div'>
        {crop.name}
      </Typography>
      {crop.id > 0 && <CropPlants />}
    </>
  );
}
