using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_editor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public string textBox = "";
    public Text text;
    public void changeString(){
        text.text = "test";
    }
}
