using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatGameManager : MonoBehaviour
{
    public static CombatGameManager instance;
    public List<GameObject> units = new();

    private void Awake()
    {
        instance = this;
    }

    public void AddNewUnit(GameObject unit)
    {
        units.Add(unit);
    }

    public List<GameObject> GetListOfUnits()
    {
        return units;
    }
}
