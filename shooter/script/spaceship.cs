using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceship : MonoBehaviour
{   
    // speed and HP
    public float playerSpeed;
    public int maxHealth = 10;
    public int currentHealth;
    public int ShieldHP = 1;

    private Vector2 playerDirection;
    private Rigidbody2D rb;

    // Canvas's
    public HealthBar healthBar;
    GameObject Shield;
    public GameManager Gamemanager;
    private float Winner;
    
    void Awake()
    {
        Shield = transform.Find("Shield").gameObject;
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(currentHealth);
        Shield.SetActive(false);
    }
    public void ShieldEquip()
    {
        Shield.SetActive(true);
    }
    void shieldstatus()
    {
        if (ShieldHP > 0 )
        {
            ShieldHP--;
        }
        if (ShieldHP == 0)
        {
            Shield.SetActive(false);
        }
    }

    bool HasShield()
    {
        return Shield.activeSelf;
    }
    void Update()
    {
        if (ShieldHP > 10)
        {
            ShieldHP = 10;
        }
        float directionX = Input.GetAxisRaw("Horizontal");
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(directionX, directionY).normalized;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(playerDirection.x * playerSpeed, playerDirection.y * playerSpeed);
        if (Input.GetKey(KeyCode.Escape))
        {
            Gamemanager.APausescreen();
        }
        if (Input.GetKey(KeyCode.G))
        {
            Gamemanager.AWinscreen();
        }
    }

    public void Damage()
    {
        if (HasShield() == true)
        {
            shieldstatus();
        }
        else if (HasShield() == false)
        {
            currentHealth--;
           healthBar.SetHealth(currentHealth);
        }

        if (currentHealth <= 0)
        {
            death();

        }
    }
    public void death()
    {
        Destroy(gameObject);
        Gamemanager.AGameOver();
        Time.timeScale = 0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PowerUps powerUp = collision.GetComponent<PowerUps>();
        if (powerUp)
        {
            if (powerUp.Ending)
            {
                Gamemanager.AWinscreen();
            }
            if (powerUp.activeSheld)
            {
                 ShieldHP = ShieldHP + powerUp.ShieldAmount;
                ShieldEquip();
            }
            if (powerUp.Healthpack)
            {
                currentHealth = currentHealth + powerUp.HealthAmount;
                healthBar.SetMaxHealth(currentHealth);
            }
            Destroy(powerUp.gameObject);
        }
    }
}
