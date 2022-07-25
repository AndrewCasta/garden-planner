const developmentURL = 'https://localhost:7104';
const productionURL = 'https://gardenplannerbackend.azurewebsites.net';

const ApiURL =
  process.env.NODE_ENV === 'development' ? developmentURL : productionURL;

export default ApiURL;
