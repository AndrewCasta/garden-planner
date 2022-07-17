import React, { useState } from 'react';

async function fetchData() {
  const response = await fetch('https://localhost:7104/weatherforecast', {
    method: 'GET',
  });
  const data = await response.json();
  console.log(data);
}
fetchData();

function App() {
  return <div className=''></div>;
}

export default App;
