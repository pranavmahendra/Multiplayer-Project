using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonosingletonGeneric<TankService>
{
    public TankView tankPrefab;


    void Start()
    {
        CreateTank();
    }


    void Update()
    {
        
    }

    public TankController CreateTank()
    {
        TankModel tankModel = new TankModel(100);

        TankController tankController = new TankController(tankModel, tankPrefab);

        return tankController;
    }
}
