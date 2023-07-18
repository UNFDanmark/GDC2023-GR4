using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Return : MonoBehaviour
{

    public Button returnButton;
    
    // Start is called before the first frame update
    void Start()
    {
        returnButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TaskOnClick()
    {
        SceneManager.LoadScene("Main menu");
    }
}
