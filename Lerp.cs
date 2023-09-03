using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    Vector3 endPosition = new Vector3(8f, 0, 0);  //target position
    Vector3 startPosition; //start position
    float lerpDuration = 5f; // duartion of time
    float elapsedTime; // elapsed time in movment
    
        

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }
        
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime; //new elapsed time in every frame
        Debug.Log(elapsedTime);
        float distanceCovered = elapsedTime / lerpDuration;
        Debug.Log(distanceCovered);
        transform.position = Vector3.Lerp(startPosition, endPosition, distanceCovered);
        
    }
}
