using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Numberguess : MonoBehaviour
{
    // Start is called before the first frame update
    public int guess;
    private int randomnum;
    private TextMeshProUGUI textMeshPro;
    void Start()
    {
        randomnum=Random.Range(1,10);
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text="Guess Number ! ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Guessnum()
    {
        if(guess>0 && guess<11)
        {
            if(guess==randomnum)
            {
                textMeshPro.text="Guessed Correctly!";
            }
            else if(guess!=randomnum)
            {
                textMeshPro.text="Guess wronged!";
            }
            
        }
        else{
            textMeshPro.text="Entered a number between 1 to 10 .!";
        }



    }
}
