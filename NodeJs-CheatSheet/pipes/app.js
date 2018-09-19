const http = require('http');
const fs = require('fs');

const server = http.createServer(function(req, res){
    console.log('req was made from: ' + req.url);
    res.writeHead(200, {'Content-Type': 'text/plain'});

    const myReadableStream = fs.createReadStream(__dirname + '/readMe.txt', 'utf8');
    myReadableStream.pipe(res);
});

server.listen(3000, '127.0.0.1');
console.log('yo man, whatsaaaap from port 3000');