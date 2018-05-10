using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{


    public void restartgame()
    {

        SceneManager.LoadScene("Assignment");

    }

    public void exitgame()
    {

        SceneManager.LoadScene("PlayGame");
        Application.Quit();

    }

}
