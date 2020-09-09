var io = require('socket.io')(process.env.PORT || 3000);

console.log("Server has started");

io.on('connection', function(socket) {
    console.log("Connection made!!");

    socket.on('disconnect', function() {
        console.log("A Player has disconnected.");
    });
});