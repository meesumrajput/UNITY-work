using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Myloop : MonoBehaviour
{
    // Start is called before the first frame update

    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        textMeshPro= GetComponent<TextMeshProUGUI>();   
    }

    public void displayfunc()
    {
        int number=-10;
        int counter=0;
        // while(!(number<=0))
        // {
        //     number-=7;
        //     counter++;

        // }
        // textMeshPro.text=$"The Remaing amount of number at break point is {number} & loop executed {counter} times";

        //     number=100;
        //     counter=0;
        do
        {
            number-=7;
            counter++;
        }while(!(number<=0));
        textMeshPro.text=$"The Remaing amount of number at break point is {number} & loop executed {counter} times";


    }
}
