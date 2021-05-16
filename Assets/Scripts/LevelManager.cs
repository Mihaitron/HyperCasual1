using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void ExitGame()
    {
        SoundManager.instance.PlayButtonClickedSound();
        Application.Quit();
    }

    public void ChangeScene(int scene_no)
    {
        StartCoroutine(ChangeSceneAsync(scene_no));
    }

    private IEnumerator ChangeSceneAsync(int scene_no)
    {
        float wait_time = SoundManager.instance.PlayButtonClickedSound();
        Debug.Log(wait_time);

        yield return new WaitForSeconds(wait_time);
        
        SceneManager.LoadScene(scene_no);
    }
}
