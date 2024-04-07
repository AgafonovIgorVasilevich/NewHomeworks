using UnityEngine.Audio;
using UnityEngine;
using TMPro;

public class MuteButton : MonoBehaviour
{
    private const string CommandOff = "Выкл. звук";
    private const string CommandOn = "Вкл. звук";
    private const float OffValue = -80;
    private const float OnValue = 0;

    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private TMP_Text _text;

    private MixerType _mixerType = MixerType.MasterVolume;
    private bool _isEnabled = true;

    public void ShiftEnabled()
    {
        _isEnabled = !_isEnabled;

        if (_isEnabled)
        {
            _mixer.audioMixer.SetFloat(_mixerType.ToString(), OnValue);
            _text.text = CommandOff;
        }
        else
        {
            _mixer.audioMixer.SetFloat(_mixerType.ToString(), OffValue);
            _text.text = CommandOn;
        }
    }
}