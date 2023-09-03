using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.IO;
[System.Serializable]


public class StoreItemLogic : MonoBehaviour
{
    //public bool wait = false;
    //public string url;

    public string imageurl;
    public Sprite webSprite;
    
   //Image popUpImage;
    //public StoreItem item = new StoreItem();
    
    StoreItem item;
    // Start is called before the first frame update
    void Start()
    {
       
        


        StartCoroutine(DownloadImageMethod(imageurl));
       
        

        //popUpImage = popUpPanel.GetComponent<Image>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setUrl(string url)
    {
        imageurl = url;
    }

    IEnumerator DownloadImageMethod(string MediaUrl)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return www.SendWebRequest();


        if (www.isNetworkError || www.isHttpError)
        { Debug.Log(www.error); }
        else
        {
            //Debug.Log(url);
            Texture2D webTexture = DownloadHandlerTexture.GetContent(www);
            webSprite = SpriteFromTexture2d(webTexture);
            gameObject.GetComponent<Image>().sprite = webSprite;

        }
    }
    Sprite SpriteFromTexture2d(Texture2D texture)
    {
        return Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
    }



  
}
