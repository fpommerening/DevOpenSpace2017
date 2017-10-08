"use strict"
var express = require('express');
var bodyParser = require('body-parser');
var app = express();
app.use(bodyParser.text());


app.post('/', function (req, res) {
  var d = new Date();
  res.send('content received ' + d.toLocaleString()  + ' ' + req.body);
});

app.listen(8080, function () {
  console.log('node webapp listen on port 8080!');
});