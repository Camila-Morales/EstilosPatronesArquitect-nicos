const express = require('express');
const app = express();
const port = 3000;

// Ruta principal
app.get('/', (req, res) => {
  res.send('Hola desde el servidor!');
});

// Iniciar servidor
app.listen(port, () => {
  console.log(`Servidor corriendo en http://localhost:${port}`);
});
