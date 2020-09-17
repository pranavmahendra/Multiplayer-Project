using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UI_Service : MonosingletonGeneric<UI_Service>
{

    private UI_Controller UIController;
    public Button fireButton;

    public event Action FirePressed;


    void Start()
    {
        UIController = new UI_Controller();

        fireButton.onClick.AddListener(InvokeFire);
    }

 
    void Update()
    {

    }

    private void InvokeFire()
    {
        FirePressed.Invoke();
    }
}
