using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public Animator animator;

    bool starting;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        if (!starting)
        {
            animator.SetBool("Fade", true);

            Invoke("gameStarting", 4);

            starting = true;
        }
        
    }
    
    public void quitGame()
    {
        Application.Quit();
    }

    public void gameStarting()
    {

        SceneManager.LoadScene(1);

    }
}
