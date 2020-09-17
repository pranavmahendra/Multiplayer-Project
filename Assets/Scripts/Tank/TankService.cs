using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonosingletonGeneric<TankService>
{
    public TankView tankPrefab;
    private Bullet_Service bullet_Service;
    public Transform bullet;


    void Start()
    {
        CreateTank();

        bullet_Service = Bullet_Service.Instance;

        UI_Service.Instance.FirePressed += bullet_fired;
    }


    //Listening to Fire button UI. Power in the parameter will be based on the slider in UI later.
    private void bullet_fired()
    {
        bullet_Service.CreateBullet(19);
        bullet_Service.controller.setPosition(tankPrefab.bulletPos.transform.position, tankPrefab.bulletPos.transform.rotation);
    }


    public TankController CreateTank()
    {
        TankModel tankModel = new TankModel(10);

        TankController tankController = new TankController(tankModel, tankPrefab);

        return tankController;
    }
}
