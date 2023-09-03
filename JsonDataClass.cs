using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class JsonDataClass
{
    public string imageurl;

    public JsonDataClass() { }

    public JsonDataClass(string url)
    {
        this.imageurl = url;
    }
}

