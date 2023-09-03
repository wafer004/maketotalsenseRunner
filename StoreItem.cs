using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class StoreItem : MonoBehaviour
{
   public GameObject popup;
    
    public GameObject gameObjectPrefab;
    public Transform GridParent;
    string fileContent;
    public Animator closeButtonAnim;
    public Animator popUpPanelAnim;
    
    JsonDataClass[] jsnData;

    // Start is called before the first frame update
    public void Start()
    {
        


        string path = @"C:\Users\0049m\Downloads\imgdisplay.Json";
        fileContent = File.ReadAllText(path);
        Debug.Log(fileContent);


        jsnData = JsonHelper.FromJson<JsonDataClass>(fileContent);
        Debug.Log(jsnData.Length);

        for (int i = 0; i < jsnData.Length; i++)
        {
            GameObject go = Instantiate(gameObjectPrefab, GridParent.transform);
            go.GetComponent<StoreItemLogic>().setUrl(jsnData[i].imageurl);
            go.GetComponent<Button>().onClick.AddListener(() => focustheImage(go.GetComponent<StoreItemLogic>().webSprite));
            popup.GetComponent<Image>().sprite = go.GetComponent<StoreItemLogic>().webSprite;

        }
      
    }
    public void focustheImage(Sprite webSprite)
    {
        //fullImgPanel.SetActive(true);
        popup.GetComponent<Image>().sprite = webSprite;
        closeButtonAnim.SetBool("isHidden", false);
        popUpPanelAnim.SetBool("isHidden", false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
   

    public void OnPopUpClose()
    {
        closeButtonAnim.SetBool("isHidden", true);
        popUpPanelAnim.SetBool("isHidden", true);
    }
}
