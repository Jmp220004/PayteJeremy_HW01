using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{
    [SerializeField] protected GameObject Powerup;
    protected override void OnHit()
    {
        // increase speed when hit
        MoveSpeed *= 2;
    }

    public override void Kill()
    {
        base.Kill();
        Powerup.SetActive(true);
        Instantiate(Powerup, gameObject.transform.position, Quaternion.identity);
        
    }
}
