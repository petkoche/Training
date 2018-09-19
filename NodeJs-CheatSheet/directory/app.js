const fs = require('fs');

// delete file
// fs.unlink('writeMe.txt');

// create directory
// fs.mkdirSync('stuff');
// delete directory
// fs.rmdirSync('stuff');


// fs.mkdir('stuff', function(){
//     fs.readFile('readMe.txt', 'utf8', function(err, data){
//         fs.writeFile('./stuff/writeMe.txt', data);
//     });
// });

fs.unlink('./stuff/writeMe.txt', function() {
    fs.rmdir('stuff');
});