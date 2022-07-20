import React, { useState, useEffect } from 'react';
import PlantCard from './PlantCard';
import PlantVarietyCard from './PlantVarietyCard';

const apiUrl = 'https://localhost:7104';

export default function CropPlants() {
  const [plantVarieties, setPlantVarieties] = useState<any[]>([]);

  const fetchPlants = async () => {
    const response = await fetch(`${apiUrl}/plant-varieties`);
    const data = await response.json();
    setPlantVarieties(data);
  };

  useEffect(() => {
    fetchPlants();
  }, []);

  return (
    <div>
      {plantVarieties.map(plant => (
        <PlantVarietyCard key={plant.id} {...plant} />
      ))}
    </div>
  );
}
