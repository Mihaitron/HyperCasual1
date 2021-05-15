using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager
{
    private static SoundManager inst;

    public static SoundManager instance
    {
        get
        {
            if (inst == null)
            {
                inst = new SoundManager();
            }

            return inst;
        }
    }

    private AudioClip pressButton = Resources.Load<AudioClip>("Sounds/PressButton");

    public float PlayButtonClickedSound()
    {
        GameObject sound_game_object = new GameObject("Sound");
        AudioSource audio_source = sound_game_object.AddComponent<AudioSource>();
        
        audio_source.PlayOneShot(this.pressButton);

        return this.pressButton.length;
    }
}
