using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Unit", menuName = "Unit")]
public class UnitScriptableObject : ScriptableObject
{
    public int health;
    public float speed;
    public int damage;
    public int armor;

    public int range;

    //model/animation
    //list of abilities

}
