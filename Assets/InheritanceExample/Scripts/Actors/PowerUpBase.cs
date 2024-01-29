using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected float PowerupDuration;
    protected float origin;
    protected float timer;


    private void Start()
    {
        origin = FindObjectOfType<TurretController>().FireCooldown;    }

    protected virtual void OnHit()
    {
        PowerUp();
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;
        StartCoroutine("waiting");

    }


    protected abstract void PowerUp();
    protected abstract void PowerDown();

    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
            OnHit();

        }

    }
    IEnumerator waiting()
    {

            yield return new WaitForSeconds(PowerupDuration);
            PowerDown();
            Destroy(gameObject);
      

    }
}