import React, { useState, useEffect } from 'react';
import { styled } from '@mui/material/styles';
import Stack from '@mui/material/Stack';
import PlantCard from './PlantCard';
import PlantVarietyCard from './PlantVarietyCard';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';
import IconButton, { IconButtonProps } from '@mui/material/IconButton';
import Button from '@mui/material/Button';

const apiUrl = 'https://localhost:7104';

export default function CropPlants() {
  const [plantVarieties, setPlantVarieties] = useState<any[]>([]);
  const [cropVarieties, setCropVarieties] = useState<any[]>([]);
  const [expanded, setExpanded] = useState(false);

  const fetchPlants = async () => {
    const response = await fetch(`${apiUrl}/plant-varieties`);
    const data = await response.json();
    setPlantVarieties(data);
  };
  const fetchCropVarieties = async () => {
    const response = await fetch(`${apiUrl}/plant-varieties/crop/1`);
    const data = await response.json();
    setCropVarieties(data);
  };

  useEffect(() => {
    fetchPlants();
    fetchCropVarieties();
  }, []);

  const handleExpandClick = () => {
    setExpanded(!expanded);
  };

  return (
    <Box
      sx={{
        backgroundColor: '#f5f5f5',
        padding: '1rem 2rem',
      }}>
      <Stack direction='row' justifyContent='space-between'>
        <Typography gutterBottom variant='h5' component='div'>
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
          {plantVarieties.map(plant => (
            <PlantVarietyCard key={plant.id} {...plant} />
          ))}
        </Box>
      )}
      {!expanded && (
        <Box
          sx={{
            display: 'flex',
            flexDirection: 'row',
            flexWrap: 'wrap',
            gap: '20px',
          }}>
          {plantVarieties.map(plant => {
            if (cropVarieties.includes(plant.id)) {
              return <PlantCard key={plant.id} {...plant} />;
            }
          })}
        </Box>
      )}
    </Box>
  );
}
