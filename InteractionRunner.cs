using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionRunner : MonoBehaviour
{
    
    //CHANGE THIS TO ACCOMADATE WHATEVER NATE IS USING
    public Text textarea;
    public Text namearea;
    public void setTextArea(Text tb){textarea=tb;}
    public Image profile;

    public void testchange(){
        textarea.text="test";

    }
    //sets Text to the new Text and waits for next click
    public void PlayChoice(Interaction i){
        Dialog dia=i.getCurrentBox();
        profile.sprite=dia.icon;
        if(dia.Speaker){
            namearea.text=dia.VTalker.getName();
        }
        else{
            namearea.text=dia.PTalker.getName();
        }
        if(dia.isPrompt()){
                    Reaction rea=dia.getReaction();
                    doReaction(rea);
                }
                if(dia.isItemTransaction()){
                    if(dia.getgiveItem()){
                        textarea.text=dia.doGiveItem();
                    }
                    else if(dia.gettakeItem()){
                        textarea.text=dia.doTakeItem();
                    }

                }
                else{
                    textarea.text=dia.getText();
                }

    }
    private void doReaction(Reaction rea){
        rea.setUp();
    }

    void Start(){    }  
}
