using UnityEngine;
using System.Collections;

public class Stat{
    private string statName;
    private string statDescription;
    private int baseValue;
    private int curValue;

	public Stat (string name, string description, int value)
    {
        statName = name;
        statDescription = description;
        baseValue = value;
	}

    public void ChangeStat(int changeValue)
    {
        curValue += changeValue;
    }

    public int GetCurValue()
    {
        return curValue;
    }
}
