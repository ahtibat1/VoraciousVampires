using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {    }
    public Vampire VTalker;
    public Player PTalker;
    public bool Speaker;//if VTalker is speaker true, else false
    public Sprite icon;

    //an Item dialog box
    public bool ItemTransaction=false;
    public bool giveItem;
    public bool takeItem;
    public string Item;
    public bool isItemTransaction(){return ItemTransaction;}
    public void setTransaction(bool t){ItemTransaction=t;}
    public void setVTalker(Vampire vamp){VTalker=vamp;}
    public void setPTalker(Player ply){PTalker=ply;}
    public void setgiveItem(bool gi, string it){giveItem=gi; Item=it;}
    public void settakeItem(bool ti, string it){takeItem=ti;Item=it;}
    public bool getgiveItem(){return giveItem;}
    public bool gettakeItem(){return takeItem;}
    public string doGiveItem(){
        PTalker.addInv(Item);
        return VTalker.getName()+"gave you" + Item;
    }
    public string doTakeItem(){
        if (PTalker.checkInv(Item)){
            PTalker.removeInv(Item);
            return VTalker.getName()+"took your" + Item;
        }
        return "you didn't have"+Item;
        
    }

    //a Prompt dialog box
    public bool prompt=false;
    public Reaction rea;
    public void setPrompt(bool p){prompt=p;}
    public bool isPrompt(){return prompt;}
    public void setReaction(Reaction r){rea=r;}
    public Reaction getReaction(){return rea;}

    //a Standard dialog box
    public string text;
    public void setText(string t){text=t;}
    public string getText(){return text;}


}
