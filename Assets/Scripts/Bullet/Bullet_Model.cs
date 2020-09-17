using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Model
{
    public Bullet_Model(int power)
    {
        this.Power = power;
    }

    public int Power { get; }

    public void DestroyBM(Bullet_Model model)
    {
        model = null;
    }
}
