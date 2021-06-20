using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform cano;
    public GameObject bala;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }


    void Shoot()
    {
        Instantiate(bala, cano.position, cano.rotation);
    }
}
