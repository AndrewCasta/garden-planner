import Card from '@mui/material/Card';
import CardMedia from '@mui/material/CardMedia';

export default function PlantCard(props: any) {
  const { name, description, image } = props;

  return (
    <Card sx={{ maxWidth: 150 }}>
      <CardMedia
        component='img'
        height='140'
        src={`/images/plant-icons/${image}`}
        alt={'props.name'}
      />
    </Card>
  );
}
