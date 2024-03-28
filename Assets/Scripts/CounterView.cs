using UnityEngine;
using TMPro;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private TMP_Text _text;

    private void OnEnable() => _counter.ValueChanged += Show;

    private void OnDisable() => _counter.ValueChanged -= Show;

    private void Show(int value) => _text.text = value.ToString();
}