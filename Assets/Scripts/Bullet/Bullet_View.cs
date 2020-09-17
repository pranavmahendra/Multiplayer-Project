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

        StartCoroutine(DestroyFuncInvoke());
    }

    void Update()
    {
        SetForce();
    }

    public void Initialize(Bulllet_Controller controller)
    {
        this.controller = controller;
    }

    public void SetForce()
    {
        this.transform.Translate(Vector3.right * 2f * Time.deltaTime);
    }

    public void DestoryView()
    {
        Destroy(gameObject);
    }

    IEnumerator DestroyFuncInvoke()
    {
        Debug.Log("Coroutine started");
        yield return new WaitForSeconds(3);
        controller.bulletDestroy();
    }
}
