using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealScript : MonoBehaviour
{
    public float ExtraHeal = 25;
    public TMPro.TextMeshProUGUI HealthText;

    public void HealBoost()
    {
        if (MainCharacter.Instance.State == 0)
        {//can artar
            MainCharacter.Instance.Health += ExtraHeal;

            //iyile�me maksimun can� ge�emez
            if (MainCharacter.Instance.Health > 100)
            {
                MainCharacter.Instance.Health = 100;
            }

            //can de�i�kenini g�nceller
            HealthText.text = MainCharacter.Instance.Health.ToString();
            //tur atlar
            MainCharacter.Instance.State = 1;
        }
        
    }


}
