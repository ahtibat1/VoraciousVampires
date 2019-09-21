using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateInteraction : MonoBehaviour
{
    public InteractionManager im;
    public Button Abut;
    public Button Bbut;
    public Button Cbut;
    public GameObject TsShell;
    public GameObject WolfieShell;
    public Text prompt;
    // Start is called before the first frame update
    void Start()
    {
        im.chooseInteraction();
        Abut.gameObject.SetActive(false);
        Bbut.gameObject.SetActive(false);
        Cbut.gameObject.SetActive(false);
        prompt.gameObject.SetActive(false);
    }
}
