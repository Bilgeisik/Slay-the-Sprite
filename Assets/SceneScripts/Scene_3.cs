using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_3 : MonoBehaviour
{
    public static Scene_3 Instance;
    
    public float EnemyNumber=1;

    public bool Stop=true;

    public GameObject wolf;

    public Animator animator;

    public bool isDamaged=false;

    

    

   
    void Start()
    {
        
        Instance=this;
    }

    
    void Update()
    {
        //wolf attack
        woolfAttack();
        
    }

    void StopWolf()
    {
        animator.SetFloat("State",0 );
        MainCharacter.Instance.State = 0;
        Stop= true;



        
        //Kalkan
        if (MainCharacter.Instance.Shield < 20)
        {
            MainCharacter.Instance.Health -=  20 - MainCharacter.Instance.Shield;


        }
        MainCharacter.Instance.Shield = 0;

        

    }

    void woolfAttack()
    {
        if (MainCharacter.Instance.State ==3 && Stop)
        {
            animator.SetFloat("State", 1);
            Invoke("StopWolf",1);
            Stop=false;
            isDamaged=true;

            if (isDamaged && Stop)
            {
                MainCharacter.Instance.Health -= 10;

            }
        }

    }

    

    
}
