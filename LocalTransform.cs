using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalTransform : MonoBehaviour
{
    Transform parentTransform, childTransform;
    // Start is called before the first frame update
    void Start()
    {
        parentTransform = transform;
        childTransform = transform.GetChild(0);
        
        //position
        //Debug.Log("parentTransform Position: "+ parentTransform.position);
        //Debug.Log("Child Transform Position: "+ childTransform.position);
        //Debug.Log("Child Transform Position: " + parentTransform.localPosition);

        ////Rotation
        //Debug.Log("Child Transform Position: " + childTransform.rotation);
        //Debug.Log("Child Transform Position: " + childTransform.localRotation);
        //Debug.Log("Child Transform Position: " + childTransform.rotation);

        //Lossy
        Debug.Log("Child Transform Position: " + parentTransform.lossyScale);
        Debug.Log("Child Transform Position: " + childTransform.lossyScale);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
