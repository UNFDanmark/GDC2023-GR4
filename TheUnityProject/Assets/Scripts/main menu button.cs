using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mainmenubutton : MonoBehaviour
{

    public Button startGoncalves;
    
    
    // Start is called before the first frame update
    void Start()
    {
        startGoncalves.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TaskOnClick()
    {

        SceneManager.LoadScene("Level 1");
        
    }

}
