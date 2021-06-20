using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AplicF : MonoBehaviour
{


    public float forca = 2.5f;
    public Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.AddForce(new Vector2(0, forca * Time.deltaTime),ForceMode2D.Impulse);
        }

    }
}
