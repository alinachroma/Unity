using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Menu;
    public Button Return;
    public Button Restart;
    bool gamePaused;

    void Start()
    {
        //visibility of Canvas (Menu) on Start (not visible until Esc is clicked)
        Menu.SetActive(false);

        Button restart = Restart.GetComponent<Button>();
        restart.onClick.AddListener(RestartScene);

        Button resume = Return.GetComponent<Button>();
        resume.onClick.AddListener(ResumeScene);
    }


    void Update()
    {
        //Pause-Menu with Esc and back
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gamePaused = !gamePaused; 
        }

        if (gamePaused) { 
            Menu.SetActive(true);
            Time.timeScale = 0.0f;
        } else {
            Menu.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }

    //Click Restart
    void RestartScene() {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    //Click Return
    void ResumeScene()
    {
        gamePaused = !gamePaused;
        Menu.SetActive(false);
        Time.timeScale = 1.0f;
    }
}

//Sources:
//https://answers.unity.com/questions/977363/how-do-i-toggle-the-visibility-of-an-object.html
//https://forum.unity.com/threads/show-canvas-by-pressing-esc.352144/
//https://docs.unity3d.com/ScriptReference/SceneManagement.Scene-name.html

//used for Shader Graph:
//https://www.youtube.com/watch?v=Ar9eIn4z6XE&ab_channel=Brackeys
//https://www.youtube.com/watch?v=3ALkvh3pJXQ&ab_channel=BoundfoxStudios-Tutorials

