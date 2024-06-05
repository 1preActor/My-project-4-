using UnityEngine;
using System.Collections;
using TMPro;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay;

    private Coroutine _coroutine;
    private bool _isCounting = false;

    private float _count = 0;

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
            _count++;
            _text.text = _count.ToString();
            yield return new WaitForSeconds(delay);
        }
    }
}
