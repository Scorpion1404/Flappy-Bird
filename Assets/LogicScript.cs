using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
  public int PlayerScore;
  public Text scoreText;
  public GameObject gameOverScreen;

  public AudioSource source;

  


  public void QuitGame(){
    Application.Quit();
  }

  private void Awake() {
    source = GetComponent<AudioSource>();

    
  }


    [ContextMenu("Increase Score")]
  public void addScore(int scoreToAdd){

    PlayerScore = PlayerScore + scoreToAdd;
    scoreText.text= PlayerScore.ToString();
    source.Play();
  }


  public void RestartGame(){

    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

    public void GameOver(){
        gameOverScreen.SetActive(true);
    }


   

}
