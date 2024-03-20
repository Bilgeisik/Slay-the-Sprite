using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;

public class Scene_2 : MonoBehaviour
{
    public static Scene_2 Instance;
    //public float State;
    public float EnemyNumber=1;

    public bool Stop=true;

    public GameObject wizard;

    public Animator animator;

    public float count=0;

    

   
    void Start()
    {
        
        Instance=this;
    }

    
    void Update()
    {
        //wizard attack
        if (MainCharacter.Instance.State ==3 && Stop)
        {
            animator.SetFloat("State", 1);
            Invoke("StopWizard",1);
            Stop=false;

            
        }
    }

    void StopWizard()
    {
        animator.SetFloat("State",0 );
        MainCharacter.Instance.State = 0;
        Stop= true;



        
        //Kalkan
        if (MainCharacter.Instance.Shield < 20)
        {
            MainCharacter.Instance.Health -=  20 - MainCharacter.Instance.Shield;


        }
        MainCharacter.Instance.Shield=0;
        count++;
 
        if(count>=2)
        {
            wizardExtraDamage();
        }   
            

    }

    void wizardExtraDamage()
    {
        MainCharacter.Instance.Health-=5;
    }

    
    
}
