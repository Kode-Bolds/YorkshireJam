using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public Text pauseText;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        pauseText.enabled = false;
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pauseText.enabled = true;
                panel.SetActive(true);
            }
            else if(Time.timeScale == 0)
            {
                Time.timeScale = 1;
                pauseText.enabled = false;
                panel.SetActive(false);
            }
        }
    }
}
