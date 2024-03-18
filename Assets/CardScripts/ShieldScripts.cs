using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScripts : MonoBehaviour
{
    public float ExtraShield = 10;
    public bool hasShield=false;

    public TMPro.TextMeshProUGUI ShieldText;

    public void ShieldBoost()
    {
        //kalkan artar
        if (MainCharacter.Instance.State == 0)
        {
            MainCharacter.Instance.Shield = 10;
            ShieldText.text = ExtraShield.ToString();

            //tur atlar
            MainCharacter.Instance.State = 1;

            hasShield=true;
        }
        

    }
}
