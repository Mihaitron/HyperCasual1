using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationManager : MonoBehaviour
{
    [SerializeField] private List<int> locationScenes;

    public void ChooseSong()
    {
        int scene_no = PlayerPrefs.GetInt("level_no");

        SceneManager.LoadScene(locationScenes[scene_no]);
    }
}
