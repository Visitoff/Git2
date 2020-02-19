using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class BulletRelease : ShootWeapon
{
    
    void Start()
    {
        
    }

    void Update()
    {
        if ((SteamVR_Actions._default.GrabPinch.GetState(SteamVR_Input_Sources.RightHand)) && Time.time >= nextTimeToFire)
            
        {
            float nextTimeToFire = Time.time + 10f / fireRate;
            Bullet();
        }
            
    }
}
