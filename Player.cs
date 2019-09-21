using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int maxSize=10;
    private int currentInvSlot=0;
    public string[] Inventory;
    public string Name;
    private Pronouns Playerpronouns;
    public bool Jujitsu;
    public int playernum;

    //sets
    public void setplayernum(int pn){playernum=pn;}
    public void setName(string newname)
    {
        if(Name == null){
            Name = newname;
        }
    }
    public void setJujitsu(bool trained)
    {
        Jujitsu = trained;
    }
    public void setPronouns(int setting)
    {
        Playerpronouns = new Pronouns();
        //1 is they/them, 2 is she/her, 3 is he/him
        if (setting == 1) {
            Playerpronouns.setSubject("they");
            Playerpronouns.setObject("them");
            Playerpronouns.setPossessiveAdj("their");
            Playerpronouns.setPossessiveNoun("theirs");
            Playerpronouns.setReflexive("themself");
            Playerpronouns.setBe("they're");
        }
        else if(setting == 2) {
            Playerpronouns.setSubject("she");
            Playerpronouns.setObject("her");
            Playerpronouns.setPossessiveAdj("her");
            Playerpronouns.setPossessiveNoun("hers");
            Playerpronouns.setReflexive("herself");
            Playerpronouns.setBe("she's");
        }
        else if(setting == 3) {
            Playerpronouns.setSubject("he");
            Playerpronouns.setObject("him");
            Playerpronouns.setPossessiveAdj("his");
            Playerpronouns.setPossessiveNoun("his");
            Playerpronouns.setReflexive("himself");
            Playerpronouns.setBe("he's");
        }
    }

    //gets
    public int getPlayerNum(){return playernum;}
    public Pronouns getPronouns() { return Playerpronouns; }
    public string getName() { return Name; }
    public bool getJujitsu() { return Jujitsu; }
    public void addInv(string newObject)
    {
        if (currentInvSlot!=maxSize-1)
        {
            Inventory[currentInvSlot] = newObject;
            currentInvSlot++;
        }
        else
        {

        }
    }

    //inventory changes
    public bool checkInv(string check)
    {
        for(int i = 0; i < maxSize; i++)
        {
            if (Inventory[i].Equals(check))
            {
                return true;
            }
        }
        return false;
    }
    public void removeInv(string oldObject)
    {
        
            for (int i = 00; i < maxSize; i++)
            {
                if (Inventory[i].Equals(oldObject))
                {
                    if (i != maxSize - 1)
                    {
                        Inventory[i] = Inventory[i + 1];
                    }
                    else
                    {
                        Inventory[i] = null;
                    }
                }
            }
            currentInvSlot--;
    }

    void Start() {
        Inventory = new string[maxSize];
        this.setPronouns(0);
        DontDestroyOnLoad(this.gameObject);
    }
}
