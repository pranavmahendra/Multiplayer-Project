using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulllet_Controller
{
    public Bulllet_Controller(Bullet_Model model, Bullet_View prefab)
    {
        this.Model = model;

        this.View = GameObject.Instantiate<Bullet_View>(prefab);

        View.Initialize(this);

    }

    public Bullet_Model Model { get; }
    public Bullet_View View { get; }


    //Function to set position of bullet.
    public void setPosition(Vector3 bulletPosition, Quaternion bulletRotation)
    {
        View.transform.position = bulletPosition;
        View.transform.rotation = bulletRotation;
    }

    public void SetForce()
    {
        View.rb2d.AddForce(Vector2.right * 1000f, ForceMode2D.Force);
    }

    //Destroy logic.
    public void bulletDestroy()
    {
        Model.DestroyBM(Model);
        View.DestoryView();
    }



}
