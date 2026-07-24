using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerAttack : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject laserPrefab;

    public Transform firePoint;

    float chargeTime = 0f;

    bool charging = false;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame) 
        {
            ShootBullet();
        }
        if (Mouse.current.rightButton.wasPressedThisFrame) 
        {
            charging = true;
            chargeTime = 0;
        }

        if (charging) 
        {
            chargeTime += Time.deltaTime;

            if (chargeTime >= 3f)
            {
                ShootLaser();

                charging = false;
            }
        }
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            charging = false;
        }
    }
    void ShootBullet()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    void ShootLaser()
    {
        Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
    }
}
