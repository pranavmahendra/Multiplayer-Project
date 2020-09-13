var app = require('express');
var server = require('http').createServer(app);
var io = require('socket.io')(server);

io.on('connection', function(socket){
    console.log('A user connected');

    socket.emit('connection');
  });

  
server.listen(3000, "127.0.0.1", () => {
    console.log("Listening to local host: 3000")
})