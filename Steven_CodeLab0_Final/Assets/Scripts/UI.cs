using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public Text score;
    public Text gameover;
    public Text restart;
    public int RestartTime = 3;
    //public float volume;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "- " + GM.score + " -";//print "-Score-" on the screen
        gameover.text = "Volume: " + GM.score;//print the final score on the screen when game is over
        //volume = AudioInput.volume;//get the input volume by player
      

        if (!GM.isActive)//if the player hit the wall, then erase the score calculator and print game over on the screen
        {
            gameover.gameObject.SetActive(true);
            score.gameObject.SetActive(false);
            Invoke("RestartTimer", RestartTime);//Set the scene to the start scene after 3 secs.
       
        }
    }

    void RestartTimer() {
        SceneManager.LoadScene("StartScene");
        GM.isActive = true;//set the game manager active
        //SceneManager.SetActiveScene().buildIndex;


    }

    
}
