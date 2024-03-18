using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{

    
    public float EnemyNumber = 2;
    public bool Stop = true;

    public static Scene Instance;

    public GameObject Enemy1;
    public GameObject Enemy2;

    public Animator Animator1;
    public Animator Animator2;

    

    //d��ardan eri�mek i�im
    private void Start()
    {
        Instance = this;
    }

    private void Update()
    {
        //ilk iskelet hareket eder
        if (MainCharacter.Instance.State == 3 && Stop)
        {
            Animator1.SetFloat("State", 1);
            Invoke("SecondSkeleton", 1);
            Stop = false;

        }

        if(EnemyNumber == 0)        
        {
            MainCharacter.Instance.Health = 100;
            SceneManager.LoadScene("LobbyCoppy");
        }


    }



    //ikinci iskelet hareket eder
    private void SecondSkeleton()
    {
        Animator1.SetFloat("State", 0);
        Animator2.SetFloat("State", 1);
        Invoke("SecondSkeletonStop", 1);


    }

    //hasar verilir
    void SecondSkeletonStop()
    {
        Animator2.SetFloat("State", 0);
        MainCharacter.Instance.State = 0;
        Stop = true;

        if (MainCharacter.Instance.Shield < 10 * EnemyNumber)
        {
            MainCharacter.Instance.Health -= 10 * EnemyNumber - MainCharacter.Instance.Shield;
           
            
        }
        
        MainCharacter.Instance.Shield = 0;
        
        MainCharacter.Instance.ExtraDamage= 0;

        

    }



}
