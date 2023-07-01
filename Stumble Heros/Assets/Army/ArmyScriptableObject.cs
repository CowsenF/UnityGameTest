using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Army", menuName = "Army")]
public class ArmyScriptableObject : ScriptableObject
{
    public GameObject unit;
    public int numberOfUnits;
    public float radius;

    //cohesion?
}
