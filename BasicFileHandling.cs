using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BasicFileHandling : MonoBehaviour
{
    string path, content;
    string[] names = {"vivvk","ram","ramesh"};
    // Start is called before the first frame update
    void Start()
    {
        path = Application.dataPath + "/Sample.txt";
       // content = "hi, how are you\n";
        if (File.Exists(path))
        {   
            Debug.Log("File found");
        }
        else
        {
            Debug.Log("file not found");
        }
        //File.WriteAllText(path, content);
        
        File.AppendAllLines(path,names);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        GUILayout.Label($"Data Path: {Application.dataPath}");
        GUILayout.Label($"Persistent Dataa path: {Application.persistentDataPath}");
    }
}
