using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }

    public void ChangeScene(int scene_no)
    {
        SceneManager.LoadScene(scene_no);
    }
}
