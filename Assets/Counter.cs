using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Collections;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay;

    public event Action CounterWork;

    private bool _isCounting = false;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _isCounting=true;

            if (_isCounting)
                StartCoroutine(Countup(_delay));
            else
                StopCoroutine(Countup(_delay));
        }
    }

    private IEnumerator Countup(float delay)
    {
        while (_isCounting)
        {
            CounterWork?.Invoke();
            yield return new WaitForSeconds(delay);
        }
    }
}
