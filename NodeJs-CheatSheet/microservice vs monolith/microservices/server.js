const server = require('express')();
const axios = require('axios');

server.get('/', async (req, res) => {
    const result = await axios.get('http://localhost:4000/db');
    res.send(result.data);
})
.get('/differentRoute', (_, res) => {
    res.send('still working');
});

server.listen(3000, () => {
    console.log('Im listening on Port 3000');
});