using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    
    private bool paused;

    public void TogglePause()
    {
        this.paused = !this.paused;

        if (paused)
        {
            this.pauseScreen.SetActive(true);
            Time.timeScale = 0;
            
            // TODO stop arrows
            GameObject.Find("Sound").GetComponent<AudioSource>().Pause();
        }
        else
        {
            this.pauseScreen.SetActive(false);
            Time.timeScale = 1;
            
            // TODO start arrows
            GameObject.Find("Sound").GetComponent<AudioSource>().UnPause();
        }
    }
}
