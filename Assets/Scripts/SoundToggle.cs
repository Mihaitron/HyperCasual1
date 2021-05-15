using System;
using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{
    [SerializeField] private Sprite soundOn;
    [SerializeField] private Sprite soundOff;

    private Image image;
    private SoundManager instance;

    private void Start()
    {
        this.image = this.GetComponent<Image>();
        this.instance = SoundManager.instance;
        
        this.ChangeSprite();
    }

    public void ToggleSound()
    {
        this.instance.ToggleSound();
        
        this.ChangeSprite();
    }

    private void ChangeSprite()
    {
        if (this.instance.IsMuted())
        {
            this.image.sprite = this.soundOff;
        }
        else
        {
            this.image.sprite = this.soundOn;
        }
    }
}
