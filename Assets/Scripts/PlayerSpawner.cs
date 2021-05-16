using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private bool rotate;
    [SerializeField] private List<GameObject> skins;
    private void Start()
    {
        int skin_no = PlayerPrefs.GetInt("character_no");

        if (rotate)
        {
            Instantiate(skins[skin_no], spawnPoint.position, Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        else
        {
            Instantiate(skins[skin_no], spawnPoint.position, Quaternion.identity);
        }
    }
}
