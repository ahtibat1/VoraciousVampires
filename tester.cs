using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tester : MonoBehaviour
{
    public Text textarea;
    public Text namearea;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void test(){
        namearea.text="Name";
        textarea.text="Text";

    }

}
