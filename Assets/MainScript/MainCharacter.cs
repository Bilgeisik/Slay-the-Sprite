using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCharacter : MonoBehaviour
{
    public float Health = 100;
    public float Shield;
    public float State=0;
    public float Level;
    public float Damage=10;
    public float ExtraDamage = 0;


    public TMPro.TextMeshProUGUI HealthText;
    public TMPro.TextMeshProUGUI ShieldText;
    





    //Di�er objeler taraf�ndan eri�mesi i�in 1
    public static MainCharacter Instance;


    //animator
    public Animator Animator;
    

    void Start()
    {
        
        //Di�er objeler taraf�ndan eri�mesi i�in 2
        Instance = this;
        
        InvokeRepeating("UI", 1, 1);
    }

    private void Update()
    {
        if (State == 2)
        {
            Animator.SetFloat("State", 1);
            Invoke("Stop", 1);


        }

        if (Health < 1)
        {
            Health = 100;
            SceneManager.LoadScene("LobbyCoppy");
            Debug.Log("öldüm");

        }
    }

    //sald�r� animasyonu
    

    //�dle a d�n��
    private void Stop() 
    {
        State = 3;
        Animator.SetFloat("State", 0);
        
        
    }

    //�l�m

    private void UI()
    {
        ShieldText.text = Shield.ToString();
        HealthText.text = Health.ToString();
    }




}
