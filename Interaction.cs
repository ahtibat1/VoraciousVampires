using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    //max boxcount should be 5 or somethin?
    private int BoxCount;
    //each string will show up in its own box
    public Dialog[] dialog;
    private int Boxnum = 0;
    
    public void setDialog(Dialog[] separateBoxes)
    {
        dialog = separateBoxes;
        BoxCount = separateBoxes.Length;
    }
    public bool stillmore(){
        if(Boxnum < dialog.Length){
            return true;
        }
        return false;
    }

    public Dialog getCurrentBox()
    {
        if (Boxnum < dialog.Length)
        {
            Boxnum++;
            return dialog[Boxnum-1];
        }
        return null;
    }
    
    void Start() { }
}
