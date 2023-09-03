using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionProperties : MonoBehaviour
{
    Quaternion currentRotation;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.identity;

        currentRotation = transform.rotation;
        Debug.Log(transform.rotation);
        Debug.Log(currentRotation.eulerAngles);
        currentRotation.eulerAngles = new Vector3(45f, 45f, 45f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
