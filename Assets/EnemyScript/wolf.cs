using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolf : MonoBehaviour
{
    public float health=300;

    public float damage=30;

    public TMPro.TextMeshProUGUI HealthText;

    public Animator animator;

    

     public void TakingDamage()
    {

        
        if (MainCharacter.Instance.State == 1)
        {

            
            health -=MainCharacter.Instance.Damage+ MainCharacter.Instance.ExtraDamage;
            HealthText.text = health.ToString();

            
            MainCharacter.Instance.State = 2;

            
            if (health < 1)
            {
                gameObject.SetActive(false);
                Scene_3.Instance.EnemyNumber -= 1;
            }

            
        }
    }
}
