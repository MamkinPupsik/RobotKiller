using UnityEngine;
using System.Threading;

public class ShotToGun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    // public GameObject impactEffect;
    public ParticleSystem muzzleFlash;

    public float fireRate = 15f;
    private float nextTimeToFire = 0f;

    public Camera fpsCam;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 11f / fireRate;
            Shoot();
            
        }    
    }

    void Shoot()
    {
        for (int i = 0; i < 10000; i++)
        {
            if (i == 9999)
            {
                muzzleFlash.Play();
                RaycastHit hit;
                if (Physics.Raycast(fpsCam.transform.position,
                     fpsCam.transform.forward, out hit, range))
                {
                    Debug.Log(hit.transform.name);

                    TargetEnemy targetenemy = hit.transform.GetComponent<TargetEnemy>();

                    if (targetenemy != null)
                    {
                        targetenemy.TakeDamage(damage);
                    }

                    // Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                }
            }
            
        }
     
        
    }
}
