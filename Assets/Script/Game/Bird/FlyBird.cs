using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyBird : MonoBehaviour
{
    [Header("Input")]
    [SerializeField] float velocity = 1;
    private Rigidbody2D rb;
    public static int playerScore = 0;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerScore = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //fly
            rb.velocity = Vector2.up * velocity;

            SoundManager.instance.PlaySound(SoundManager.instance.wingSound);


        }

    }
    //
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundManager.instance.PlaySound(SoundManager.instance.hitSound);
        SceneManager.LoadScene(2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ScoreZone")
        {
            SoundManager.instance.PlaySound(SoundManager.instance.pointSound);
            playerScore++;           
            if (playerScore > PlayerPrefs.GetInt("bestScore") )
            {
                PlayerPrefs.SetInt("bestScore", playerScore);
                PlayerPrefs.Save();
                
            }
            
        }
    }
    
}
