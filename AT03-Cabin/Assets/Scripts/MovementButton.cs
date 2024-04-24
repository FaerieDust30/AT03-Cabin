using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

// Faye Butler - 24/04/2024

public class MovementButton : MonoBehaviour
{

    [SerializeField] private Transform[] waypoint;

    private LocationMovementMenu moveMenu;

    private void Awake()
    {
        moveMenu = FindObjectOfType<LocationMovementMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveMenu.menu.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                MoveToWaypoint(0);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                MoveToWaypoint(1);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                MoveToWaypoint(2);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                MoveToWaypoint(3);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                MoveToWaypoint(4);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                MoveToWaypoint(5);
            }
        }
    }

    public void MoveToWaypoint(int place)
    {
       waypoint[place].GetComponent<NavigationWaypoint>().Activate();
    }
}
