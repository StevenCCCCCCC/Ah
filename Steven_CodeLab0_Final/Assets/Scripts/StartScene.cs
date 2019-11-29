using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public float volume1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        volume1 = AudioInput.volume;//get the input volume by player
        if (volume1 > 0.5f) {
            ChangeScene("SampleScenes");
        }//if the voice is loud enough, then start the game
    }

    //change to a new scene
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); //change to whatever scene is named by sceneName
    }
}
