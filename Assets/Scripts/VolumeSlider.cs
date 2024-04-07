using UnityEngine.Audio;
using UnityEngine;

public class VolumeSlider : MonoBehaviour
{
    private const float Min = -80;
    private const float Max = 0;

    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private MixerType _mixerType;

    public void SetVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(_mixerType.ToString(), Mathf.Lerp(Min, Max, volume));
    }
}