using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Tank : EnemyBase
{
    float motion;
    float stopped = 0;
    protected override void OnHit()
    {
        if(MoveSpeed != stopped)
        {
            motion = MoveSpeed;
        }
        MoveSpeed = stopped;
        StartCoroutine(waiting());
        

    }

    IEnumerator waiting()
    {
        yield return new WaitForSeconds(1);
        MoveSpeed = motion;
    }
}
