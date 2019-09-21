using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCreation : MonoBehaviour
{
    public PlayerManager pm;
    public Player p1;
    public Player p2;
    public Player p3;
    public Player p4;

    public void OneP(){
        Player[] plas = new Player[]{p1};
        pm.setPlayers(plas);
    }
    public void TwoP(){
        Player[] plas = new Player[]{p1,p2};
        pm.setPlayers(plas);
    }
    public void ThreeP(){
        Player[] plas = new Player[]{p1,p2,p3};
        pm.setPlayers(plas);
    }
    public void FourP(){
        Player[] plas = new Player[]{p1,p2,p3,p4};
        pm.setPlayers(plas);
    }


    // Start is called before the first frame update
    void Start(){
        p1.setplayernum(0);
        p2.setplayernum(1);
        p3.setplayernum(2);
        p4.setplayernum(3);
    }

}
