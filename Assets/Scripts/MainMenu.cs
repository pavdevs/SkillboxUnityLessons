using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = System.Random;

public class MainMenu : MonoBehaviour
{

    private int[] startedArray = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };

    public void RangeSum() 
    {
        var oddSum = 0;

        for (int i = 7; i <= 21; i++)
        {
            if (i % 2 == 0) 
            {
                oddSum += i;
            }
        }

        Debug.Log($"Сумма четных чисел в диапозоне от 7 до 21 равна {oddSum}");
    }

    public void RangeSumEven() 
    {
        var everSum = 0;
        
        foreach (int i in startedArray)
        {
            if (i % 2 == 0) 
            {
                everSum += i;
            }
        }

        Debug.Log($"Сумма четных чисел в массиве {startedArray} равна {everSum}");
    }

    public void IndexFirst()
    {
        GetFirstIndexWith(34);
        GetFirstIndexWith(55);
    }

    private void GetFirstIndexWith(int digit) 
    {
        var firstIndex = -1;

        for (int i = 0; i < startedArray.Length; i++)
        {
            if (startedArray[i] == digit)
            {
                firstIndex = i;
                break;
            }
        }

        Debug.Log($"Индекс первого вхождения числа {digit} равен {firstIndex}");
    }

    public void SortSelection() 
    {
        int[] startingArray = GetRandomedArrayWith(25);

        bool isSorted = false;

        PrintArray(startingArray);

        int currentArrayIndex = 0;

        while (isSorted == false) 
        {
            int minDigit = startingArray[currentArrayIndex];
            int minDigitIndex = currentArrayIndex;

            for (int i = currentArrayIndex; i < startingArray.Length; i++)
            {
                if (startingArray[i] < minDigit)
                {
                    minDigit = startingArray[i];
                    minDigitIndex = i;
                }
            }

            var replacedValue = startingArray[currentArrayIndex];
            startingArray[minDigitIndex] = replacedValue;
            startingArray[currentArrayIndex] = minDigit;

            currentArrayIndex++;

            if (currentArrayIndex == startingArray.Length)
            {
                isSorted = true;
            }
        }

        PrintArray(startingArray);
    }

    private int[] GetRandomedArrayWith(int length)
    {
        var random = new Random();

        int[] resultArray = new int[length];

        for (int i = 0; i < resultArray.Length; i++)
        {
            resultArray[i] = random.Next(-100, 200);
        }

        return resultArray;
    } 

    private void PrintArray(int[] array)
    {
        String uuid = Guid.NewGuid().ToString();

        Debug.Log($"Старт вывода массива {uuid}");
        foreach (int item in array)
        {
            Debug.Log(item);
        }
        Debug.Log($"Конец вывода массива {uuid}");
    }
}
