using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField]
    private Door currentDoor;
    [SerializeField]
    private Animator animator;
    private int count = 0;
    
    private void Start()
    {
        animator.Play("pressureplateup");
        count = 0;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
            currentDoor.AddPressurePlate(this);
            animator.Play("pressureplatedown");
            count = count + 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            count = count - 1;
            if (count == 0)
            {
                currentDoor.RemovePressurePlate(this);
                animator.Play("pressureplateup");
            }
        }
    }
}
