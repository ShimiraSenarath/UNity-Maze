using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject HitTrigger;
    public int cur_coins = 0;
    public int max_coins = 0;
    public Text coinsLeft;
    public GameObject Door;
    bool gameHasEnded = false;
    public float restartDelay = 0.3f;
    public GameObject HitGrass;
    public GameObject HitTrigger6;
    public GameObject HitTrigger11;
    public GameObject HitTrigger12;
    public GameObject HitTriggerFlow2;
    public GameObject HitTriggerFlow3;
    public GameObject HitTriggerFlow4;
    public GameObject HitTriggerFlow7;
    public GameObject HitTriggerWall1;
   

    void Start() {

        Door.SetActive(false);
        max_coins = cur_coins;
        UpdateUI();
    
    }

    public void TriggerHit()
    {

        Debug.Log("Level Won");
        HitTrigger.SetActive(true);
         
    }

    public void TriggerHit6()
    {

        Debug.Log("Level Won6");
        HitTrigger6.SetActive(true);

    }

    public void TriggerHit11()
    {

        Debug.Log("Level Won11");
        HitTrigger11.SetActive(true);

    }

    public void TriggerHit12()
    {

        Debug.Log("Level Won12");
        HitTrigger12.SetActive(true);

    }

    public void TriggerHitFlow2()
    {

        Debug.Log("Level Won");
        HitTriggerFlow2.SetActive(true);

    }

    public void TriggerHitFlow3()
    {

        Debug.Log("Level Won");
        HitTriggerFlow3.SetActive(true);

    }

    public void TriggerHitFlow4()
    {

        Debug.Log("Level Won");
        HitTriggerFlow4.SetActive(true);

    }

    public void TriggerHitFlow7()
    {

        Debug.Log("Level Won");
        HitTriggerFlow7.SetActive(true);

    }

    public void TriggerHitwall1()
    {

        Debug.Log("WallWall");
        HitTriggerWall1.SetActive(true);

    }
    
    public void GrassHit() {

        Restart();
    
    }

  /*  public void WallHit()
    {

       RestartWall();

    }*/

    public void UpdateUI() {
        if (cur_coins > 0)
        {
            coinsLeft.text = "Coins Left:" + cur_coins.ToString("D2") + "/" + max_coins.ToString("D2");
        }
        else if (cur_coins <= 0)
        {

            Door.SetActive(true);
        }
    }

   public void EndGame() {

       if (gameHasEnded == false)
       {
           gameHasEnded = true;
           Debug.Log("Game Over");
           Invoke("Restart", restartDelay);

       }
    }

   public void Restart() {

       SceneManager.LoadScene("ReseartGame");

       //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   
   }

   public void RestartWall()
   {

       SceneManager.LoadScene("ReseartGameHitWall");

       //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

   }

   public void RestartCoin()
   {

       SceneManager.LoadScene("RestartGameHitFakeCoin");

       //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

   }

   public void RestartObstacle()
   {
       SceneManager.LoadScene("RestartGameHitObstacle");

       //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

   }

   public void RestartFier()
   {
       Debug.Log(" RestartFire");
       SceneManager.LoadScene("RestartGameHitFire");

       //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

   }

}
