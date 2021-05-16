using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChooseLevel : MonoBehaviour
{
    [SerializeField] private List<Sprite> levels;
    [SerializeField] private TMP_Text levelNameContainer;
    [SerializeField] private Image levelImage;

    private int current;

    private void Start()
    {
        this.current = 0;
        
        this.SetImage();
        this.SetCharacterName();
    }

    private void SetCharacterName()
    {
        this.levelNameContainer.text = this.levels[this.current].name;
    }

    private void SetImage()
    {
        this.levelImage.sprite = this.levels[this.current];
    }

    public void GoLeft()
    {
        SoundManager.instance.PlayButtonClickedSound();
        
        this.current--;
        if (this.current < 0)
        {
            this.current = 0;
            return;
        }
        
        this.SetImage();
        this.SetCharacterName();
    }
    
    public void GoRight()
    {
        SoundManager.instance.PlayButtonClickedSound();
    
        this.current++;
        if (this.current >= this.levels.Count)
        {
            this.current = this.levels.Count - 1;
            return;
        }

        this.SetImage();
        this.SetCharacterName();
    }

    public void Select()
    {
        SoundManager.instance.PlayButtonClickedSound();
        PlayerPrefs.SetInt("level_no", this.current);
        
        Debug.Log(this.current);
    }
}
