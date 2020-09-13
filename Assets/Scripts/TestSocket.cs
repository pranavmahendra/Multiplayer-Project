using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;
using System;

public class TestSocket : MonoBehaviour
{
    private SocketIOComponent socket;

    void Start()
    {
        socket = GetComponent<SocketIOComponent>();
        socket.Connect();

        socket.On("connection", onConnected);
        socket.On("error", onError);
    }

    private void onError(SocketIOEvent obj)
    {
        Debug.Log("Server connection error: " + obj);
    }

    private void onConnected(SocketIOEvent obj)
    {
        Debug.Log("Server Connected" + obj);
    }

    void Update()
    {
        
    }
}
