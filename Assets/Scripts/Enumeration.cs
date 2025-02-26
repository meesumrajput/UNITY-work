using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public  enum DamagePlayer
{
    single=1,
    Double=2,
    quad=4
}
public class Enumeration : MonoBehaviour
{
    // Start is called before the first frame update

    private TextMeshProUGUI textMeshPro;
    public DamagePlayer Destruction;
    public int damage;
    void Start()
    {
        textMeshPro= GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void damageshow()
    {
        if(Destruction==DamagePlayer.single)
        {
            int tempDamage=(int)DamagePlayer.single * damage;
            textMeshPro.text= $" The damage is single which is {tempDamage}";
        }
         if(Destruction==DamagePlayer.Double)
        {
            int tempDamage=(int)DamagePlayer.Double * (damage);
            textMeshPro.text= $" The damage is double which is {tempDamage}";
        }
        if(Destruction==DamagePlayer.quad)
        {
            int tempDamage=(int)DamagePlayer.quad * damage;
            textMeshPro.text= $" The damage is Quad4x which is {tempDamage}";
        }
    }
}
