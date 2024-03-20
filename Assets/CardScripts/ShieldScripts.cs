using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScripts : MonoBehaviour
{
    public float ExtraShield = 10;
    public bool hasShield=false;

    public TMPro.TextMeshProUGUI ShieldText;

    

    public GameObject Counter;
    public GameObject Canvas;
    Transform child;
    int childCount;

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

            Fetch();
        }


        



    }

    private void Fetch()
    {
        child = Canvas.transform.GetChild(2);
        child.transform.SetParent(Counter.transform);
        child.gameObject.SetActive(false);

        child = Canvas.transform.GetChild(2);
        child.transform.SetParent(Counter.transform);
        child.gameObject.SetActive(false);

        child = Canvas.transform.GetChild(2);
        child.transform.SetParent(Counter.transform);
        child.gameObject.SetActive(false);



        childCount = Counter.transform.childCount;

        child = Counter.transform.GetChild(Random.Range(0, childCount));
        child.gameObject.SetActive(true);
        child.transform.SetParent(Canvas.transform);
        child.transform.localPosition = new Vector3(100, -327, 0);

        childCount = Counter.transform.childCount;

        child = Counter.transform.GetChild(Random.Range(0, childCount));
        child.gameObject.SetActive(true);
        child.transform.SetParent(Canvas.transform);
        child.transform.localPosition = new Vector3(0, -327, 0);

        childCount = Counter.transform.childCount;

        child = Counter.transform.GetChild(Random.Range(0, childCount));
        child.gameObject.SetActive(true);
        child.transform.SetParent(Canvas.transform);
        child.transform.localPosition = new Vector3(-100, -327, 0);


    }


}
