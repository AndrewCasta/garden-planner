import React, { useState, useEffect } from 'react';
import PlantCard from '../components/PlantCard';

const url = 'https://localhost:7104/plant-varieties';

export default function CropPlants() {
  const [plantVarieties, setPlantVarieties] = useState<any[]>([]);

  const fetchPlants = async () => {
    const response = await fetch(url);
    const data = await response.json();
    setPlantVarieties(data);
  };

  useEffect(() => {
    fetchPlants();
  }, []);

  return (
    <div>
      {plantVarieties.map(plant => (
        <PlantCard key={plant.id} {...plant} />
      ))}
    </div>
  );
}
