using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    

    public GameObject goodeffect; 
     public GameObject badeffect; 

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // other.GetComponent<Player>().health--;                      
            // Instantiate(effect, transform.position, Quaternion.identity);
            // Destroy(gameObject);
            if(gameObject.CompareTag("office"))
            {
               // Instantiate(effect, transform.position, Quaternion.identity);
                other.GetComponent<Player>().gamewon();
            }
            else
            {
                if(gameObject.CompareTag("Good"))
                {
                    Instantiate(goodeffect, transform.position, Quaternion.identity);
                }
                if(gameObject.CompareTag("Bad"))
                {
                    Instantiate(badeffect, transform.position, Quaternion.identity);
                }
                Destroy(gameObject);
            }
        }
       
    }
    
}
