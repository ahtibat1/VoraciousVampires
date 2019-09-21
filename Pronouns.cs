using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pronouns : MonoBehaviour
{
    private string Subject;
    private string Object;
    private string PossessiveAdj;
    private string PossessiveNoun;
    private string Reflexive;
    private string Be;

    public void setSubject(string they)
    {
        //they did it
        Subject = they;
    }
    public void setObject(string them)
    {
        //it was them
        Object = them;
    }
    public void setPossessiveAdj(string their)
    {
        //their cat
        PossessiveAdj = their;
    }
    public void setPossessiveNoun(string theirs)
    {
        //it's theirs
        PossessiveNoun = theirs;
    }
    public void setReflexive(string themself)
    {
        //they told themself
        Reflexive = themself;
    }
    public void setBe(string theyre)
    {
        //they're here
        Be = theyre;
    }

    public string getSubject(){ return Subject; }
    private string getObject() { return Object; }
    private string getPossessiveAdj() { return PossessiveAdj; }
    private string getPossessiveNoun() { return PossessiveNoun; }
    private string getReflexive() { return Reflexive; }
    private string getBe() {return Be; }
    void Start() { }
}
