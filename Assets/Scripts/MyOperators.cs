using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyOperators : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI textMeshPro;
    public int amount=0;
    public float percentage = .2f;
    void Start()
    {
        textMeshPro=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void display(){
            int xp=100;

        textMeshPro.text = $"power is{xp}";
    }
    public void tipcalculator(){

        float tipamount=(float) amount * percentage;
        int totalamount=(int)tipamount+ amount;

                textMeshPro.text = $"power is {totalamount}";



    }
}
