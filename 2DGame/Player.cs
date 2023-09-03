using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpForce;
    [SerializeField]
    bool isGrounded = false;
    public Animator jumpAnimator;
    Rigidbody2D rb;
    AudioSource jumpAudio;

    public int health;
    public GameObject spawner;
    public GameObject restartDisplay;
    public GameObject completedDisplay;
    public Text healthDisplay;

    public int money;
    public Text moneyDisplay;

    public GameObject effect;

    public float timer = 90f;
    public Text timertext;

    float targettime = 90f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        jumpAudio= GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (isGrounded==false)
            {
                isGrounded = true;
            }
        }
       
    }
    
    // Update is called once per frame
    void Update()
    {
        // moneyDisplay.text = money.ToString();


        // if (health <= 0)
        // {
        //     spawner.SetActive(false);
        //     restartDisplay.SetActive(true);
        //     Destroy(gameObject);
        // }

        //healthDisplay.text = health.ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {

                rb.AddForce(Vector2.up * jumpForce);
                isGrounded = false;
                jumpAnimator.SetTrigger("Jump");
                jumpAudio.Play();
                Instantiate(effect,transform.position,Quaternion.identity); 
            }
        }   
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            float minutes = Mathf.FloorToInt(timer / 60);
            float seconds = Mathf.FloorToInt(timer % 60);

            timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
           targettime -= Time.deltaTime;
            if(targettime <= 0)
            {
                spawner.GetComponent<Spawner>().DisplayOfficeObstacle();
            }
        }
        else{
            float minutes = 0f;
            float seconds = 0f;

            timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            gamelost();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Good"))
        {
            timer = timer + 20f;
            
        }
        if (other.CompareTag("Bad"))
        {
            timer = timer - 40f;
            
        }
    }
    public void gamewon()
    {
        spawner.SetActive(false);
        completedDisplay.SetActive(true);
        Destroy(gameObject);
    }
    public void gamelost()
    {
        spawner.SetActive(false);
        restartDisplay.SetActive(true);
        Destroy(gameObject);
    }
}
