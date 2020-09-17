using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    public int speed;
    private Camera mainCam;

    public TankController tankController;

    private Vector3 mousePos;
    private Vector3 mouseViewportPos;

    //Rotating the turret


    void Start()
    {
        mainCam = Camera.main;
    }


    void Update()
    {
        tankController.TankMovement();

        tankController.ShootBullet();


        mousePos = Input.mousePosition;
        mousePos.z = 10f;

        mouseViewportPos = mainCam.ScreenToWorldPoint(mousePos);
 
        Debug.Log("MMouse viewport Pos: " + mouseViewportPos);
    }

    public void Initialize(TankController tc)
    {
        this.tankController = tc;
    }

   


}
