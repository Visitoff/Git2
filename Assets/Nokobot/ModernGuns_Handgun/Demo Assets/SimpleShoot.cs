using UnityEngine;
using Valve.VR;

public class SimpleShoot : ShootWeapon  
{
    void Update()
    {
        // использование дельты тайм вместо тайма. использовать накопительный счетчик с обнулением
        if ((SteamVR_Actions._default.GrabPinch.GetState(SteamVR_Input_Sources.RightHand)) && Time.time >= nextTimeToFire)
        {
            
            // формула на проверку до выстрела
            nextTimeToFire = Time.time + 10f / fireRate;
            Shoot();
            CasingRelease();
        }
    }
}