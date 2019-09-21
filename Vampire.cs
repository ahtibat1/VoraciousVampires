using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampire : MonoBehaviour
{
    public string Name;
    public int[] Relations;

    public int getRelation(int player)
    {
        return Relations[player];
    }
    public void setName(string nam) { Name = nam; }
    public string getName()
    {
        return Name;
    }
    void Start() {
        Relations = new int[] { 0, 0, 0, 0 };
        DontDestroyOnLoad(this.gameObject);
    }
}
