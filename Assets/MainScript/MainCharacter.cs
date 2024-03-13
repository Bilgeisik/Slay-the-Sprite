using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    public float Health = 100;
    public float Shield;
    public float State;
    public float Level;
    public float Damage=10;
    public float ExtraDamage = 0;



    //Di�er objeler taraf�ndan eri�mesi i�in 1
    public static MainCharacter Instance;


    //animator
    public Animator Animator;
    

    void Start()
    {
        //Di�er objeler taraf�ndan eri�mesi i�in 2
        Instance = this;
    }

    //sald�r� animasyonu
   public void Animation()
    {
        Animator.SetFloat("State", 1);
        Invoke("Stop", 1);
    }

    //�dle a d�n��
    private void Stop() 
    {

        Animator.SetFloat("State", 0);
        Scene.Instance.State = 3;
    }

    //�l�m
    private void Update()
    {
        if (Health < 1)
        {
            gameObject.SetActive(false);
            
        }
    }
    
    
       
    

}
