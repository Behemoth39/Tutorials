const express = require("express");
const dotenv = require("dotenv");
const http = require("http");
var cors = require("cors");
const app = express();
const { Server } = require("socket.io");
const server = http.createServer(app);

app.use(cors());
const io = new Server(server, {
  cors: {
    origin: "http://localhost:3000",
  },
});

// add error handling

dotenv.config({ path: "./config/.env" });
const PORT = process.env.PORT;

io.on("connection", (socket) => {
  console.log(`User Connected: ${socket.id}`);
  socket.emit("message", "Welcome"); // barely working

  socket.on("join_room", (data) => {
    socket.broadcast.emit("message", "User joined chat"); // barely working
    socket.join(data);
  });

  socket.on("send_message", (data) => {
    socket.to(data.room).emit("receive_message", data);
  });

  socket.on("disconnect", () => {
    io.emit("message", "User Disconnected"); // barely working
  });
});

server.listen(PORT, () => {
  console.log("listening on *:3005");
});
