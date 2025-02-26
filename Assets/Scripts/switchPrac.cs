using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum States
{
    summer=1,
    winter=2,
    spring=3,
    autumn=4
}


public class NewBehaviourScript : MonoBehaviour
{
    public States switchcheck;
    public int swichchqvalue;
    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro= GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void displaySwitch()
    {
        switch(switchcheck)
        {
            case States.summer:
            textMeshPro.text=$"The Weather is hot {(int)States.summer}";
            break;
            case States.winter:
            textMeshPro.text=$"The Weather is Winter {(int)States.winter}";
            break;case States.spring:
            textMeshPro.text=$"The Weather is Spring {(int)States.spring}";
            break;
            default:
            textMeshPro.text=$"The weather is Autumn : {(int)States.autumn} ";
            break;

        }
    }
}
