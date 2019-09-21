using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reaction : MonoBehaviour
{
    public Vampire VTalker;
    public Player PTalker;
    public string Prompt;
    public string[] Responses;
    private string Response;
    public string Atext;
    public string Btext;
    public string Ctext;
    public Button Abut;
    public Button Bbut;
    public Button Cbut;
    public Text A;
    public Text B;
    public Text C;
    public Text textarea;
    public Text standardTA;
    public int Agood; //1=good, 0= neutral, -1=bad
    public int Bgood; //1=good, 0= neutral, -1=bad
    public int Cgood; //1=good, 0= neutral, -1=bad
    public Image profile;
    public Sprite emotionchangeA;
    public Sprite emotionchangeB;
    public Sprite emotionchangeC;

    public void setUp(){
        textarea.text=Prompt;
        textarea.gameObject.SetActive(true);
        A.text=Atext;
        B.text=Btext;
        C.text=Ctext;
        Abut.gameObject.SetActive(true);
        Bbut.gameObject.SetActive(true);
        Cbut.gameObject.SetActive(true);

        Abut.onClick.AddListener(Afunc);
        Bbut.onClick.AddListener(Bfunc);
        Cbut.onClick.AddListener(Cfunc);
    }

    private void Afunc(){
        Response=Responses[0];
        if(emotionchangeA!=null){profile.sprite=emotionchangeA;}
        if(Agood<0){
            VTalker.Relations[PTalker.playernum]--;
        }
        if(Agood>0){
            VTalker.Relations[PTalker.playernum]++;
        }
        close();
    }
    private void Bfunc(){  
        Response=Responses[1];
        if(emotionchangeB!=null){profile.sprite=emotionchangeB;}
        if(Bgood<0){
            VTalker.Relations[PTalker.playernum]--;
        }
        if(Bgood>0){
            VTalker.Relations[PTalker.playernum]++;
        }
        close();
    }
    private void Cfunc(){  
        Response=Responses[2];
        if(emotionchangeC!=null){profile.sprite=emotionchangeC;}

        if(Cgood<0){
            VTalker.Relations[PTalker.playernum]--;
        }
        if(Cgood>0){
            VTalker.Relations[PTalker.playernum]++;
        }
        close();
    }


    private void close(){
        standardTA.text=Response;
        Abut.gameObject.SetActive(false);
        Bbut.gameObject.SetActive(false);
        Cbut.gameObject.SetActive(false);
        textarea.gameObject.SetActive(false);

    }



    void Start() { }
}
