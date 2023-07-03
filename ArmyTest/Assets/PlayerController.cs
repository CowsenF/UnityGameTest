using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerController : MonoBehaviour
{
    [SerializeField] ArmyController selectedArmy = null;
    public List<ArmyController> listOfArmy = new();

    [SerializeField] private Camera cam;

    //Spawn armys

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if(hitInfo.collider.gameObject.GetComponent<ArmyController>() != null && listOfArmy.Contains(hitInfo.collider.gameObject.GetComponent<ArmyController>()))
                {
                    selectedArmy = hitInfo.collider.gameObject.GetComponent<ArmyController>();
                }
                else if(selectedArmy != null)
                {
                    selectedArmy.SetNewPosition(hitInfo.point);
                }
            }
        }
    }
}
