using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealScript : MonoBehaviour
{
    public float ExtraHeal = 25;
    public TMPro.TextMeshProUGUI HealthText;


    public GameObject Counter;
    public GameObject Canvas;
    Transform child;
    int childCount;
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
