
//const path = require('path');
//var pathObj = path.parse(__filename);

//console.log(pathObj);

const fs = require('fs');

//const files = fs.readdirSync('./');
//console.log(files);

fs.readdir('./', function(err, files)
{
    if (err) console.log('Error', err);
    else console.log('Result', files);
});


//const log = require('./logger');
//log('message');
/*
function sayHello(name) {
    console.log('Hello ' + name);
    }
  
    sayHello('Mark');
   //console.log(window); not defined
   // console.log() // global
  // global.console.log;
   console.log(module);
   */