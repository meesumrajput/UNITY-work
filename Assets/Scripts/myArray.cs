using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;

public class myArray : MonoBehaviour
{
    // Start is called before the first frame update
        private TextMeshProUGUI textMeshPro;
        public int[] Donkeykong;
    void Start()
    {
        textMeshPro= GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void showmessage()
    {
        int avg=Donkeykong[0]+Donkeykong[1]+Donkeykong[2];
        avg/=Donkeykong.Length;
        textMeshPro.text=avg.ToString();

    }

}
