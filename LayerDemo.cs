using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int layer = 1;
        int layermask = 1 << 8;
        Debug.Log(LayerMask.LayerToName(0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
