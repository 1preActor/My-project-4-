using System;
using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.CounterWork += UpdateScore;
    }

    private void OnDisable()
    {
        _counter.CounterWork -= UpdateScore;
    }

    private void UpdateScore()
    {
        _text.text = _counter.Count.ToString();
    }

}
