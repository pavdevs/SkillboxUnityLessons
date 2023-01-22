using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lesson5_1 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 1; i < 6; i++)
        {
            Debug.Log($"Вывел число {i}");
        }

        for (int i = 7; i > 1; i--)
        {
            Debug.Log($"Вывел число обратный порядок {i}");
        }

        for(int i = 0; i <= 100; i++) 
        {
            if (isDigitNatural(i)) {
                Debug.Log($"Число {i} простое");
            }
        }
    }

    private bool isDigitNatural(int digit) 
    {
        switch (digit) 
        { 
            case 0:
                return false;
            case 1:
                return false;
            case 2:
                return true; 
            default:
                var count = 0;
                for (int i = 2; i < digit; i++)
                {
                    if (digit % i == 0) {
                        count++;
                    }
                }

                if (count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }

 
    }
}
