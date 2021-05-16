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
    private List<AudioClip> songs;
    private bool muted = false;

    public SoundManager()
    {
        this.songs = new List<AudioClip>();
        
        this.songs.Add(Resources.Load<AudioClip>("Sounds/Future Funk"));
        this.songs.Add(Resources.Load<AudioClip>("Sounds/Turn It Up"));
        this.songs.Add(Resources.Load<AudioClip>("Sounds/Sleazy Fight"));
    }

    public float PlayButtonClickedSound()
    {
        if (!this.muted)
        {
            GameObject sound_game_object = new GameObject("Sound");
            AudioSource audio_source = sound_game_object.AddComponent<AudioSource>();
        
            audio_source.PlayOneShot(this.pressButton);
        }

        return this.pressButton.length;
    }

    public float PlaySong(int song_no)
    {
        AudioClip song = this.songs[song_no];
        
        if (!this.muted)
        {
            GameObject sound_game_object = new GameObject("Sound");
            AudioSource audio_source = sound_game_object.AddComponent<AudioSource>();
        
            audio_source.PlayOneShot(song);
        }

        return song.length;
    }

    public void ToggleSound()
    {
        this.muted = !this.muted;
    }

    public bool IsMuted()
    {
        return this.muted;
    }
}
