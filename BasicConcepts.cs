using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicConcepts : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObjectPrefab;
    GameObject cubeParent;
    GameObject cubeChild;
    // Start is called before the first frame update
    void Start()
    {

        cubeParent = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubeChild = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cubeChild.transform.parent=cubeParent.transform;

        //cubeParent.SetActive(false);
        //cubeChild.SetActive(false);

        Debug.Log(cubeChild.activeSelf);
        Debug.Log(cubeChild.activeInHierarchy);

       GameObject cubePrefab = Instantiate(gameObjectPrefab, new Vector3(2,2,2), Quaternion.Euler(90f,90f,0f));
        
        Debug.Log(cubePrefab.isStatic); //isstatic

        Debug.Log(cubeParent.layer);    //layer

        Debug.Log(cubeChild.scene);

        cubeParent.tag = "Player";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
