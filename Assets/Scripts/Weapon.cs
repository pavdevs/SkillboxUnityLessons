using System;
using UnityEngine;

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintStatsInfo()
    {
        Debug.Log($"Object name is {name} and experience is {damage}");
    }
}

