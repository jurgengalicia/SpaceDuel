using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonCannon : MonoBehaviour
{
    public GameObject photonBlast;
    public float bulletSpeed;
    public float fireRate = 0.4f;
    private float nextFire = 0.0f;
    private Vector3 bulletSpawnPoint;

    //made use of time, and fire rate for a slower
    //rate of fire when holding down the fire button
    private void firePhotonCannon(){
    nextFire = Time.time + fireRate;
    bulletSpawnPoint = transform.position + (transform.up * 0.7f);

    GameObject pBClone = Instantiate(photonBlast, bulletSpawnPoint,
                                     transform.rotation);
    Rigidbody2D rbClone = pBClone.GetComponent<Rigidbody2D>();
    rbClone.velocity = transform.up * bulletSpeed;
    Rigidbody2D shipRb = transform.GetComponent<Rigidbody2D>();
    rbClone.velocity += shipRb.velocity;
    }

    // Update is called once per frame
    void Update()
    {
      if(transform.name.EndsWith("One", System.StringComparison.Ordinal)) {
        if(Input.GetButton("FirePlayerOne") && Time.time > nextFire) {
            firePhotonCannon();
        }
    } else {
        if(Input.GetButton("FirePlayerTwo") && Time.time > nextFire) {
            firePhotonCannon();
        }
    }
    }
}
