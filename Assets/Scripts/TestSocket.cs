using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;
using System;

public class TestSocket : MonoBehaviour
{
    private SocketIOComponent socket;
    public List<GameObject> Players;

    public static int playerCount = 0;

    void Start()
    {
        socket = GetComponent<SocketIOComponent>();
        socket.Connect();

        socket.On("connection", onConnected);
        socket.On("disconnect", onDisconnected);
        //socket.On("error", onError);
        socket.On("spawn", onSpawned);

    }

    private void onDisconnected(SocketIOEvent obj)
    {
        
        playerCount--;
    }

    private void onSpawned(SocketIOEvent obj)
    {
        Debug.Log("Spawned");

        TankService.Instance.CreateTank(playerCount);
        playerCount++;
    }

    private void onError(SocketIOEvent obj)
    {
        Debug.Log("Server connection error: " + obj);
    }

    private void onConnected(SocketIOEvent obj)
    {
        Debug.Log("Server Connected");

        socket.Emit("Move");


    }
    
}
