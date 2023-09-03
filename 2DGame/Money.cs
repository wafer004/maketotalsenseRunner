using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Money : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    
    
    public GameObject effect;
    
    void Update()
    {
       

        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
  

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }
}
