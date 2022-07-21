import Typography from '@mui/material/Typography';
import React from 'react';
import CropPlants from './CropPlants';

export default function PlanningArea() {
  return (
    <>
      <Typography gutterBottom variant='h2' component='div'>
        Crop Name
      </Typography>
      <CropPlants />
    </>
  );
}
