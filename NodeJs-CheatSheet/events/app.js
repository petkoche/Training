var events = require('events');
var util = require('util');

var Person = function(name){
    this.name = name;
};

util.inherits(Person, events.EventEmitter);

var james = new Person('james');
var marry = new Person('marry');
var raiden = new Person('raiden');
var people = [james, marry, raiden];

people.forEach(function(person){
    person.on('speak', function(mssg){
        console.log(person.name + ' said: ' + mssg);
    });
});

james.emit('speak', 'Hey dudes');
raiden.emit('speak', 'I want to drive');