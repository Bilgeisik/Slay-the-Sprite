using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyScript : MonoBehaviour
{


    public void Boss1 ()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Loop1()
    {

        SceneManager.LoadScene("Loop1");

    }
    public void Boss2 ()
    {
        SceneManager.LoadScene("Scene2");
    }

}
