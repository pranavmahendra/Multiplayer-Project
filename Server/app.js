var app = require('express');
var server = require('http').createServer(app);
var io = require('socket.io')(server);

var playerCount = 0;

io.on('connection', function(socket){
    console.log('A user connected');

    socket.emit('connection', {'id' : 101, 'gems' : 1000});

    //Broadcasted to other clients
    socket.broadcast.emit('spawn');
    playerCount++;

    //Will send data only to player that just connected.
    for(i = 0; i < playerCount; i++)
    {
      socket.emit('spawn');
      console.log('Sending spawn to new player.');
    }

    socket.on('disconnect', function(){
      console.log('Client disconnected');
      playerCount--;
    });


    socket.on('Move', function(data){
        console.log('Client is moving');
    });    
  });

 
server.listen(3000, "127.0.0.1", () => {
    console.log("Listening to local host: 3000")
})