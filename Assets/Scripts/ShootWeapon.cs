using UnityEngine;
using Valve.VR;

public class ShootWeapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 15f;
    public float impactForce = 30f;

    public float nextTimeToFire = 0f; // повторный параметр

    public GameObject muzzleFlashPrefab;
    public Transform barrelLocation;
    public float shotPower = 100f;
    public GameObject casingPrefab;
    public Transform casingExitLocation;

    public void Shoot()
    {
         // копирование патрона и задавание ему стартовой позиции
        GameObject tempFlash;
        tempFlash = Instantiate(muzzleFlashPrefab, barrelLocation.position, barrelLocation.rotation);
        Destroy(tempFlash, 0.5f); // на эффекте

        GetComponent<AudioSource>().Play();
        //на патроне должно быть
        RaycastHit hit;
        if (Physics.Raycast(barrelLocation.transform.position, barrelLocation.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
        //--------
    }
   public void Bullet() // передвижение патрона должно быть на патроне
    {
        GetComponent<AudioSource>().Play();
        GameObject bullet;
        bullet = Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower); // обратный эдд форсе
        Destroy(bullet, 0.7f); // только если не во что не попал
   }
    public void CasingRelease()
    {
        GameObject casing;
        casing = Instantiate(casingPrefab, casingExitLocation.position, casingExitLocation.rotation) as GameObject;
        casing.GetComponent<Rigidbody>().AddExplosionForce(550f, (casingExitLocation.position - casingExitLocation.right * 0.3f - casingExitLocation.up * 0.6f), 1f);
        casing.GetComponent<Rigidbody>().AddTorque(new Vector3(0, Random.Range(100f, 500f), Random.Range(10f, 1000f)), ForceMode.Impulse);
        Destroy(casing, 3f); // так не делается
    }
}   