using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public Score score;
    public GameManager gameManager;
    public Sprite playerDied;
    public ColumnSpawner columnSpawner;

    SpriteRenderer sp;
    Animator anim;

    int angle;
    int maxAngle = 20;
    int minAngle = -60;

    bool touchGround;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        rb.gravityScale = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
        if ((Input.GetMouseButton(0) || Input.GetKeyDown("space")) && 
            GameManager.gameOver == false && 
            GameManager.gameIsPaused == false)
        {
            if (GameManager.gameHasStarted == false)
            {
                rb.gravityScale = 0.8f;
                Flap();
                columnSpawner.InstantiateColumn();
                gameManager.GameHasStarted();
            }
            else
            {
                Flap();
            }
            
        }

        PlayerRotation();

    }

    void Flap()
    {
        AudioManager.audiomanager.Play("Wings");
        rb.velocity = Vector2.zero;
        rb.velocity = new Vector2(rb.velocity.x, speed);
    }

    void PlayerRotation()
    {
        if (rb.velocity.y > 0)
        {
            rb.gravityScale = 0.8f;
            if (angle <= maxAngle)
            {
                angle = angle + 1;
            }
        }
        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = 0.7f;

            if (rb.velocity.y < -1.3f)
            {
                if (angle >= minAngle)
                {
                    angle = angle - 3;
                }
            }

            
        }
        if (touchGround == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("column"))
        {
            print("We have scored");
            score.Scored();
        }
        else if (collision.CompareTag("Pipe"))
        {
            //game over
            gameManager.GameOver();
            AudioManager.audiomanager.Play("Hit");
            AudioManager.audiomanager.Play("Die");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("gnd")){
            if (GameManager.gameOver == false)
            {
                //game over
                gameManager.GameOver();
                GameOver();
            }
            else
            {
                
                GameOver();
                //game over (Player)
            }
        }
    }

    void GameOver()
    {
        
        touchGround = true;
        anim.enabled = false;
        sp.sprite = playerDied;
        transform.rotation = Quaternion.Euler(0, 0, -90);
    }
}
