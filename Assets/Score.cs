using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private Counter _counter; 

    public float _count = 0;

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
        _count++;
        Debug.Log("Текущий счёт: " +  _count);
    }


}
