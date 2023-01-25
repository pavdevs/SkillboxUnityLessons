using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeHandler : MonoBehaviour
{
    [SerializeField] Text timeCountText;
    [SerializeField] Text loopCountText;
    [SerializeField] Text countdownText;

    [SerializeField] GameObject gameoverText;

    private int countdownSeconds = 18;
    private int countdownCurrentTime;
    private bool isGameRoundRunned;

    private void Awake()
    {
        isGameRoundRunned = true;
    }

    private void FixedUpdate()
    {
       
        if (isGameRoundRunned)
        {
            int currentTime = Mathf.RoundToInt(Time.time);
            countdownCurrentTime = countdownSeconds - currentTime;
            timeCountText.text = $"Текущее время: {currentTime}";
            loopCountText.text = $"Количество кругов: {Mathf.RoundToInt(currentTime / 10)}";
            countdownText.text = $"Осталось времени {countdownCurrentTime}";
            if (countdownCurrentTime == 0)
            {
                isGameRoundRunned = false;
                gameoverText.SetActive(true);
            }
        }
    }
}
