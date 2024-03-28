using System.Collections;
using UnityEngine;
using System;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _tickTime = 0.5f;
    [SerializeField] private int _tickValue = 1;

    private bool _isWork = false;
    private int _value = 0;

    public event Action<int> ValueChanged;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("Была нажата ЛКМ");
            _isWork = !_isWork;

            if (_isWork)
                StartCoroutine(CounterWork());
        }
    }

    private IEnumerator CounterWork()
    {
        WaitForSeconds delay = new WaitForSeconds(_tickTime);

        print("Счетчик запущен");

        while (_isWork)
        {
            yield return delay;
            _value += _tickValue;
            ValueChanged?.Invoke(_value);
        }

        print("Счетчик остановлен");
    }
}