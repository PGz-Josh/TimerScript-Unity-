/*  Timer Script for Unity Programming Course
 *  Professor: Derek Prate
 *  Authors: Joshua Yang & Jim
 *  Date: 2/9/2020
 *  Use this script to attach to an object where
 *  the timer will count down and switch to a
 *  game over scene once the timer hits 0.
 *  
 *  Instructions:
 *  1)  Make sure there is TWO scenes, an GAME scene where the timer will show, and an "You Lost/Died" scene for when the timer runs out
 *  2)  Make sure the build settings (Files -> Build Setting -> Scenes in Builds) has both, the game and lost scene, inside
 *  3)  Create a UI GameObject (GameObject -> UI -> Text)
 *  4)  Attach the script to the GameObject
 *  5)  Make sure the "You Died/Lost" Scene name is set in the Unity Inspector Menu of the TIMER script provided
 *  6)  Adjust the timer preference to your liking by changing the value in the script and how it looks in Unity
 *  7)  Enjoy!
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    public string levelToLoad;
    private float timer = 10f; //CHANGE THIS VALUE TO HOW LONG YOU WANT THE PLAYER TO HAVE BEFORE THE GAME SWITCHES SCENE
    private Text timerSeconds;

    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f0");
        if(timer <= 0)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
