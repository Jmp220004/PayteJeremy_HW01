using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFirePowerUp : PowerUpBase
{
    protected float fire;
    protected override void OnHit()
    {
        base.OnHit();
       
    }

    protected override void PowerUp()
    {
        Debug.Log("Powerup");
        FindObjectOfType<TurretController>().FireCooldown /= 2 ;
    }

    protected override void PowerDown()
    {
        Debug.Log("PowerDown");
        FindObjectOfType<TurretController>().FireCooldown = 0.5f;
    }

}
