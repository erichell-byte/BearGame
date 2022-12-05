using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] GameObject _mutedMusicImage;
    [SerializeField] GameObject _mutedSoundsImage;
    [SerializeField] GameObject _notMutedSoundsImage;

    private bool _isMutedMusic;
    private bool _isMutedSounds;

    public void MusicOnOff()
    {
        if (_isMutedMusic)
        {
            _mutedMusicImage.SetActive(false);
            _isMutedMusic = false;
        }
        else
        {
            _mutedMusicImage.SetActive(true);
            _isMutedMusic = true;
        }
    }

    public void SoundsOnOff()
    {
        if (_isMutedSounds)
        {
            _mutedSoundsImage.SetActive(false);
            _notMutedSoundsImage.SetActive(true);
            _isMutedSounds = false;
        }
        else
        {
            _mutedSoundsImage.SetActive(true);
            _notMutedSoundsImage.SetActive(false);
            _isMutedSounds = true;
        }
    }
}
