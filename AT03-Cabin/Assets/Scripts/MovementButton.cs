using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementButton : MonoBehaviour
{
    [SerializeField] private Transform mainDoor;
    [SerializeField] private Transform solarPanels;
    [SerializeField] private Transform kitchen;
    [SerializeField] private Transform fireplace;
    [SerializeField] private Transform bathroom;
    [SerializeField] private Transform bedroom;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToMainDoor()
    {
        transform.position = mainDoor.position;
    }
    public void MoveToSolarPanels()
    {
        transform.position = solarPanels.position;
    }
    public void MoveToKitchen()
    {
        transform.position = kitchen.position;
    }
    public void MoveToFireplace()
    {
        transform.position = fireplace.position;
    }
    public void MoveToBathroom()
    {
        transform.position = bathroom.position;
    }
    public void MoveToBedroom()
    {
        transform.position = bedroom.position;
    }

}
