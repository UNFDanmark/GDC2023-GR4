using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialKnap : MonoBehaviour
{

    public Button tutorialButton;
    
    // Start is called before the first frame update
    void Start()
    {
        tutorialButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TaskOnClick()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
