using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Sprite[] bar;
    public Image healthBarUI;

    private mover player;


    void Start()
    {
        player = GameObject.Find("Player").GetComponent<mover>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBarUI.sprite = bar[player.maxHealth];
    }
}
