using System.Collections;
using UnityEngine;

public class Bad_Guy_Shoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject firePoint;
    public float timing = 1.0f;
    public float bulletForce = 1500.0f;

    [SerializeField] private Movement locMoveRef;

    [SerializeField] private bool canShoot = true;

    void Start()
    {
        locMoveRef = GetComponent<Movement>();
        StartCoroutine(ShootTimer(timing));
    }


    public IEnumerator ShootTimer(float timeBetweenShots)
    {
        yield return new WaitForSeconds(timeBetweenShots);
        StartCoroutine(ShootObject());
        StartCoroutine(ShootTimer(timeBetweenShots));
    }

    public IEnumerator ShootObject()
    {
        canShoot = true;

        GameObject newBullet = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation) as GameObject;

        // get Rigidbody2D component of instantiated Bullet and control
        Rigidbody2D tempRigidBody = newBullet.GetComponent<Rigidbody2D>();

        // push the Bullet forward by amount bulletForce
        
            // fireForward is fire to the right
        tempRigidBody.AddForce(-transform.up * bulletForce);

        yield return new WaitForSeconds(1.0f);

        canShoot = true;
        // basic Clean Up, set Bullets to self destruct after 5 seconds
        Destroy(newBullet, 5.0f);
    }
}
