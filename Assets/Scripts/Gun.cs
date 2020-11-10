using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float fireRate;
    protected float lastFireTime;

    public Ammo ammo;
    public AudioClip liveFire;
    public AudioClip dryFire;

    // Start is called before the first frame update
    void Start()
    {
        lastFireTime = Time.time - 10;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

    protected void Fire()
    {
        //checking to see if the current gun has ammo
        if (ammo.HasAmmo(tag))
        {
            // if it does then play the regular fire sound clip
            GetComponent<AudioSource>().PlayOneShot(liveFire);
            GetComponentInChildren<Animator>().Play("Fire");
            ammo.ConsumeAmmo(tag);
        }
        else
        {
            // otherwise play the empty fire clip
            GetComponent<AudioSource>().PlayOneShot(dryFire);
        }

        
    }
}
