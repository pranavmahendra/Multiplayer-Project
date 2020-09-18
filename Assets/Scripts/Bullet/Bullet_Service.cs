using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bullet_Service : MonosingletonGeneric<Bullet_Service>
{
    public Bulllet_Controller controller;
    public Bullet_View prefab;
   

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    //Power value will be derived from somewhere else.

    public Bulllet_Controller CreateBullet(int power)
    {
        Bullet_Model model = new Bullet_Model(power);

        Bulllet_Controller control = new Bulllet_Controller(model, prefab);

        this.controller = control;

        return control;
    }


        
}
