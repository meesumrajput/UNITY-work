using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MidLabs : MonoBehaviour
{
    private TextMeshProUGUI TextMeshPro;
    private bool statement=true;
    private string verb="harm";
    private string noun="Meesum";
    private string adjective="Honest person";
    private int number=9;
    private string plural="Fatima";
    private float percent=100.0f;


    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro=GetComponent<TextMeshProUGUI>();
        TextMeshPro.text=$"This is a Statement {statement} that i did not {verb} the {noun} . i am not guilty , i am a {adjective} person . This act was performed by a {number} number, wondering {plural}. i am {percent} sure.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
