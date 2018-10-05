const server = require('express')();
const { databaseFunction } = require('./database');

server.get('/', (req, res) => {
    
    res.send(databaseFunction());
})

server.listen(3000, () => {
    console.log('Im listening on Port 3000');
});