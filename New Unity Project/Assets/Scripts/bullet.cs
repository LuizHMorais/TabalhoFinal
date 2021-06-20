using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
 
    public float speed;
    private float timeDestroy;
    public int damage;

    void Start()
    {
        timeDestroy = 1.0f;
        Destroy(gameObject, timeDestroy);
        
        
    }
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemy"))
        {
            EnemyController enemy = other.GetComponent<EnemyController>();

            if(enemy != null)
            {
                enemy.DamageEnemy(damage);
            }
        }
        Destroy(gameObject);
    }
    

}
