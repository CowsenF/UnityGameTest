using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

[RequireComponent(typeof(NavMeshAgent))]
public class UnitController : MonoBehaviour
{
    [SerializeField] private UnitScriptableObject unitInfo;

    public ArmyController armyGroup;

    public void SetArmyGroup(ArmyController newArmy)
    {
        this.armyGroup = newArmy;
    }
}
