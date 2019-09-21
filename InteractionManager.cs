using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class InteractionManager : MonoBehaviour
{
    //Interaction Manager for each location with all possible locations
    //Chose an interaction based on either vampire that exists at location or severe relation
    public Interaction[] interactions;
    public Vampire[] vampires;
    public PlayerManager pm;
    public Vampire hangin;
    public InteractionRunner ir;
    public Text ta; //set this to the actual box
    private Interaction currentchoice;
    
    public void setText(Text t){ta=t;}
    public void setHangin(Vampire v){hangin=v;}
    public void setInteractions(Interaction[] locationtalks){interactions=locationtalks;}
    public void setVampires(Vampire[] vamps){vampires=vamps;}
    public void setPM(PlayerManager p){pm=p;}
    public void chooseInteraction(){
        Player cp = pm.getCurrentPlayer();

        //int cpnm = cp.getPlayerNum();
        /*
        for(int i=0;i<vampires.Length;i++){
            if(vampires[i].getRelation(cpnm)<-3||vampires[i].getRelation(cpnm)>3){
                //chose an interaction with this vamp
            }
        }
        if(hangin!=null){
            //choose an interaction with this vamp
        }
        */
        int n=interactions.Length;
        System.Random rng = new System.Random();
        int k = rng.Next(n);
        currentchoice=interactions[k];
        ir.PlayChoice(interactions[k]);
    }
    public void continueConvo(){
        if(currentchoice.stillmore()){
            ir.PlayChoice(currentchoice);
        }
        else{
            SceneManager.LoadScene("map_scene");
            //switch to map
        }

    }

    void Start() { 
    }
    

}
