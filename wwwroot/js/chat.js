"use strict";

// connect to signalr server
var connection = new signalR.HubConnectionBuilder().withUrl("/chat").build();

// document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", addMessageToChat);

connection.start()
    .catch(error => {
        console.error(error.message);
    });

function sendMessageToHub(message) {
    connection.invoke("SendMessage", message);
}