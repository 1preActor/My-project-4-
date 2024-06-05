using System;
using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _delay;

    private Coroutine _coroutine;
    private bool _isCounting = false;

    public float Count = 0;
    public event Action CounterWork;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isCounting == true)
            {
                _isCounting = false;
            }
            else
            {
                _isCounting = true;

                if (_isCounting)
                    _coroutine = StartCoroutine(Countup(_delay));
                else
                    if(_coroutine !=  null)
                    StopCoroutine(_coroutine);
            }
        }
    }

    private IEnumerator Countup(float delay)
    {
        while (_isCounting)
        {
            Count++;
            CounterWork?.Invoke();
            yield return new WaitForSeconds(delay);
        }
    }
}
