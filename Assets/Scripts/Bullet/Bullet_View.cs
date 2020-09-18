using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_View : MonoBehaviour
{
    public Bulllet_Controller controller;
    public Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        //StartCoroutine(DestroyFuncInvoke());
    }


    private void FixedUpdate()
    {
        controller.SetForce();
    }


    public void Initialize(Bulllet_Controller controller)
    {
        this.controller = controller;
    }

    public void SetForce()
    {
       
    }

    public void DestoryView()
    {
        Destroy(gameObject);
    }

    public void DestroyFuncInvoke()
    {
        controller.bulletDestroy();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            DestroyFuncInvoke();
        }
    }
}
