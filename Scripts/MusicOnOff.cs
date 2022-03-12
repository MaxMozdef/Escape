using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MusicOnOff : MonoBehaviour
{
    [SerializeField] private string lineButtonON, lineButtonOFF;
    [SerializeField] private TextMeshProUGUI buttonControlMusicText;
    [SerializeField] private AudioSource gameAudio;
    private bool musicPlay;

    private void Start()
    {
        buttonControlMusicText.text = lineButtonOFF;
    }
    public void PleyOrNotPlayMusic()
    {
        if (musicPlay == true)
        {
            gameAudio.volume = 0.15f;
            buttonControlMusicText.text = lineButtonOFF;
            musicPlay = false;
            return;
        }
        if (musicPlay == false)
        {
            gameAudio.volume = 0.00f;
            buttonControlMusicText.text = lineButtonON;
            musicPlay = true;
            return;
        }
    }
    

}
