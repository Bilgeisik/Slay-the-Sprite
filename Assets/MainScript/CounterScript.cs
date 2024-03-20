using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CounterScript : MonoBehaviour
{
    int childCount;
    Transform child;

    public GameObject Canvas;
    void Start()
    {
        Fetch();
    }

    
    void Update()
    {
        
    }


    public void Fetch()
    {
        childCount = gameObject.transform.childCount;

        child =gameObject.transform.GetChild(Random.Range(0, childCount ));
        child.gameObject.SetActive(true);        
        child.transform.SetParent(Canvas.transform);
        child.transform.localPosition = new Vector3(100, -327, 0);

        childCount = gameObject.transform.childCount;

        child = gameObject.transform.GetChild(Random.Range(0, childCount));
        child.gameObject.SetActive(true);       
        child.transform.SetParent(Canvas.transform);
        child.transform.localPosition = new Vector3(0, -327, 0);

        childCount = gameObject.transform.childCount;

        child = gameObject.transform.GetChild(Random.Range(0, childCount));
        child.gameObject.SetActive(true);        
        child.transform.SetParent(Canvas.transform);
        child.transform.localPosition = new Vector3(-100, -327, 0);

    }
}
