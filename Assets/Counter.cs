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
            if (_isCounting)
            {
                if (_coroutine != null)
                    StopCoroutine(_coroutine);

                _isCounting = false;
            }
            else
            {
                _isCounting = true;
                _coroutine = StartCoroutine(Counting(_delay));
            }
        }
    }

    private IEnumerator Counting(float delay)
    {
        var wait = new WaitForSeconds(delay);

        while (_isCounting)
        {
            _count++;
            _text.text = _count.ToString();
            yield return wait;
        }
    }
}
