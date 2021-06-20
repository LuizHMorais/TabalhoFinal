using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaBala : MonoBehaviour
{
    public GameObject balas;
    public GameObject cano;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(balas, new Vector3(cano.transform.position.x, cano.transform.position.y, cano.transform.position.x), Quaternion.identity);
        }
    }
}
