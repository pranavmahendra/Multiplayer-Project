using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    public int speed;
    public TankController tankController;
    public Transform turret;

    public Transform bulletPos;

    [HideInInspector]
    public Vector3 mousePos;
    [HideInInspector]
    public Vector3 mouseViewportPos;

    //Rotating the turret


    void Start()
    {

    }


    void Update()
    {
        
        tankController.TankMovement();

        //tankController.ShootBullet();

        tankController.MousePos();

        //RaycastHit2D hit = Physics2D.Raycast(turret.transform.position, turret.transform.forward, 10f);

        Debug.DrawRay(turret.transform.position, turret.transform.right, Color.red);
    }



    public void Initialize(TankController tc)
    {
        this.tankController = tc;
    }

 
}
