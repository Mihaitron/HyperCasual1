using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChooseCharacter : MonoBehaviour
{
    [SerializeField] private int characterDistance = 50;
    [SerializeField] private List<GameObject> characters;
    [SerializeField] private TMP_Text characterNameContainer;

    private List<GameObject> spawnedCharacers = new List<GameObject>();

    private int current = 0;

    private void Start()
    {
        Vector3 spawn_position = Vector3.zero;
        
        foreach (GameObject character in characters)
        {
            GameObject spawned_character = Instantiate(character, this.transform, false);

            spawned_character.transform.localPosition = spawn_position;
            spawn_position.x -= this.characterDistance;
            
            this.spawnedCharacers.Add(spawned_character);
        }

        this.SetCharacterName();
    }

    private void SetCharacterName()
    {
        string name = this.spawnedCharacers[this.current].name.Replace("(Clone)", "");
        
        this.characterNameContainer.text = name;
    }

    public void GoLeft()
    {
        this.current--;
        if (this.current < 0)
        {
            this.current = 0;
            return;
        }

        foreach (GameObject character in this.spawnedCharacers)
        {
            Vector3 position = character.transform.localPosition;

            position.x -= this.characterDistance;
            character.transform.localPosition = position;
        }
        
        this.SetCharacterName();
    }
    
    public void GoRight()
    {
        this.current++;
        if (this.current >= this.spawnedCharacers.Count)
        {
            this.current = this.spawnedCharacers.Count - 1;
            return;
        }

        foreach (GameObject character in this.spawnedCharacers)
        {
            Vector3 position = character.transform.localPosition;

            position.x += this.characterDistance;
            character.transform.localPosition = position;
        }
        
        this.SetCharacterName();
    }

    public void Select()
    {
        PlayerPrefs.SetInt("character_no", this.current);
    }
}
