using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moreOperators : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    //     int x=1,y=2;
    //     bool result=x==y;
    //    // Debug.Log(result);

    //    int playerhealth=100;
    //    int levelpoints=200;
    //     result= !(playerhealth>=levelpoints);
    //     Debug.Log(!result);
        

       // int coins=100;
        int totallives=3;
        int maxlives=10;
        bool isPremium=true;

        bool ShouldIncreaseDifficulty= isPremium==true &&totallives<maxlives;
         Debug.Log(ShouldIncreaseDifficulty);

        // string fname=null;
        // bool check=fname!=null && fname.ToUpper() == "MEESUM RAZA";
        // Debug.Log(check);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
