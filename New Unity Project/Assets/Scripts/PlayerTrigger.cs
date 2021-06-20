using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTrigger : MonoBehaviour
{

    private mover player;
    
    void Awake()
    {
        player = GameObject.Find("Player").GetComponent<mover>();
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemy"))
        {
            if (!player.invulnerable)
            {
                player.DamagePlayer();
            }
        }



    }




}
