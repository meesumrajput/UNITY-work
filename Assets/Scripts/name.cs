using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class name : MonoBehaviour
{
    // Start is called before the first frame update
    
        public string fname,lname;

        private TextMeshProUGUI textMeshPro;
    void Start()
    {
        textMeshPro=GetComponent<TextMeshProUGUI>();
        textMeshPro.text=$"Hello {fname} {lname} !";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
