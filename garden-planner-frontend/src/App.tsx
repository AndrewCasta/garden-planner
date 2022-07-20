import React, { useState } from 'react';
import Button from '@mui/material/Button';
import Nav from './components/Nav';
import PlanningArea from './components/PlanningArea';

function App() {
  return (
    <Nav>
      <PlanningArea />
    </Nav>
  );
}

export default App;
