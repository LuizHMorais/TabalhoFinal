using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mover : MonoBehaviour{
    public int maxHealth;
    public bool invulnerable = false;
    public bool isAlive = true;
    public float maxSpeed;
    public float jumpForce;

    private bool m_FacingRight = true;

    private bool grounded;
    private bool jumping;

    private Rigidbody2D rb2d;
    private Animator anim;
    private SpriteRenderer sprite;

    public Transform groundCheck;
    public Transform bulletSpawn;

    public float fireRate;
    private float nextFire;
    public GameObject bulletObject;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {

    }


    void Update()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        if (Input.GetButtonDown("Jump") && grounded)
        {
            jumping = true;
        }


        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            Fire();
        }


    }

    void FixedUpdate(){
        if (isAlive)
        {

            float move = Input.GetAxis("Horizontal");

            anim.SetFloat("Speed", Mathf.Abs(move));

            rb2d.velocity = new Vector2(move * maxSpeed, rb2d.velocity.y);

            // If the input is moving the player right and the player is facing left...
            if (move > 0 && !m_FacingRight)
            {
                // ... flip the player.
                Flip();
            }
            // Otherwise if the input is moving the player left and the player is facing right...
            else if (move < 0 && m_FacingRight)
            {
                // ... flip the player.
                Flip();
            }


            if (jumping)
            {
                rb2d.AddForce(new Vector2(0f, jumpForce));
                jumping = false;
            }
            anim.SetBool("JumpFall", rb2d.velocity.y != 0f);

        }else
            rb2d.velocity = new Vector2(0,rb2d.velocity.y);
        }

    void Fire()
    {
        anim.SetTrigger("Fire");
        nextFire = Time.time + fireRate;
        Debug.Log("bala");
        Instantiate(bulletObject, bulletSpawn.position, bulletSpawn.rotation);

    }

    void Flip()
    {
        m_FacingRight = !m_FacingRight;

        transform.Rotate(0f, 180f, 0f);

    }



    IEnumerator Damage()
    {
        
        
        for (float i = 0f; i < 1f; i += 0.1f)
        {
            sprite.enabled = false;
            yield return new WaitForSeconds(0.1f);
            sprite.enabled = true;
            yield return new WaitForSeconds(0.1f);
        }
        invulnerable = false;

    }

    public void DamagePlayer()
    {
       if(isAlive) { 
        invulnerable = true;
        maxHealth --;

        StartCoroutine(Damage());
        if (maxHealth < 1)
        {
            isAlive = false;
            anim.SetTrigger("Death");
            Invoke ("ReloadLevel", 2f);
        }
        }

    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
