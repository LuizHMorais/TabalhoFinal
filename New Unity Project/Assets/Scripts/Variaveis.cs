using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{
    /*private float vel = 2.5f;*/

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /* if(Input.GetKey(KeyCode.RightArrow))
         {
             transform.Translate (new Vector3 (vel * Time.deltaTime,0,0));
         }

         if (Input.GetKey(KeyCode.LeftArrow))
         {
             transform.Translate(new Vector3(-vel * Time.deltaTime, 0, 0));
         }
     }*/

        float h = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(h * Time.deltaTime, 0, 0));

    }
}