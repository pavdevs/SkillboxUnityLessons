using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    private Character hero = new Character();

    private Character enemy = new Character(name: "Canalya");

    void Start()
    {
        hero.PrintStatsInfo();
        enemy.PrintStatsInfo();
    }
}
