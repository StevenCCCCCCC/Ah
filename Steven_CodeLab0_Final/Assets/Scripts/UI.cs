using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public Text score;
    public Text gameover;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score.text = "- " + GM.score + " -";//print "-Score-" on the screen
        gameover.text = "Score: " + GM.score;//print the final score on the screen when game is over



        if (!GM.isActive)//if the player hit the wall, then erase the score calculator and print game over on the screen
        {
            gameover.gameObject.SetActive(true);
            score.gameObject.SetActive(false);


        }
    }

}
