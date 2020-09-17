using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    public TankController(TankModel tankModel, TankView prefab)
    {
        this.TankModel = tankModel;

        this.TankView = prefab;
        prefab.Initialize(this);
    }

    public TankModel TankModel { get; }
    public TankView TankView { get; }
    private float CannonAngle;


    public void TankMovement()
    {
        Debug.Log("Value of Tank rotation is: " + TankView.transform.rotation.y);

        if (Input.GetKey(KeyCode.D))
        {
            TankView.transform.Translate(Vector3.right * TankView.speed * Time.deltaTime, Space.World);


            if (TankView.transform.rotation.y == 1)
            {
                Debug.Log("Flip tank");
                TankView.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
            }

        }
        else if (Input.GetKey(KeyCode.A))
        {
            TankView.transform.Translate(Vector3.left * TankView.speed * Time.deltaTime, Space.World);

            if (TankView.transform.rotation.y == 0)
            {
                Debug.Log("Flip tank");
                TankView.transform.rotation = new Quaternion(0.0f, 180.0f, 0.0f, 0.0f);
            }
        }
    }


    //public void ShootBullet()
    //{
    //    if (Input.GetKeyDown(KeyCode.Mouse0))
    //    {
    //        Debug.Log("Shoot bullet");
    //    }
    //}


    public void MousePos()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            CannonAngle += Input.GetAxis("Mouse Y") * 1000f * Time.deltaTime;
            CannonAngle = Mathf.Clamp(CannonAngle, 1, 90);
            TankView.turret.localRotation = Quaternion.AngleAxis(CannonAngle, Vector3.forward);
        }
    }
}
