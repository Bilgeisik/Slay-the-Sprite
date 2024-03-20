using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public float health=150;

    public float damage=20;

    public TMPro.TextMeshProUGUI HealthText;

    public Animator animator;

    

     public void TakingDamage()
    {

        if(MainCharacter.Instance.State ==0)
        {
            health-=MainCharacter.Instance.Damage;
            HealthText.text = health.ToString();

            MainCharacter.Instance.State =2;

            if (health < 1)
            {
                gameObject.SetActive(false);
                Scene_2.Instance.EnemyNumber -= 1;
            }


        }
        if (MainCharacter.Instance.State == 1)
        {

            
            health -=MainCharacter.Instance.Damage+ MainCharacter.Instance.ExtraDamage;
            HealthText.text = health.ToString();

            
            MainCharacter.Instance.State = 2;

            
            if (health < 1)
            {
                gameObject.SetActive(false);
                Scene_2.Instance.EnemyNumber -= 1;
            }

            
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
