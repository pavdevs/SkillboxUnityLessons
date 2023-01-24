using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private readonly string name;
    private readonly int experience = 0;

    public Character()
    {
        name = "Default character";
    }

    public Character(string name)
    {
        this.name = name;
    }

    public Character(string name, int experience)
    {
        this.name = name;
        this.experience = experience;
    }

    public string GetName()
    {
        return name;
    }

    public int GetExperience()
    {
        return experience;
    }

    public void PrintStatsInfo()
    {
        Debug.Log($"Object name is {name} and experience is {experience}");
    }
}
