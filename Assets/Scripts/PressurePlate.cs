using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField]
    private Door currentDoor;
    [SerializeField]
    private Animator animator;
    
    private void OnTriggerEnter(Collider other)
    {
        currentDoor.AddPressurePlate(this);
        animator.Play("pressureplatedown");
    }
    private void OnTriggerExit(Collider other)
    {
        currentDoor.RemovePressurePlate(this);
        animator.Play("pressureplateup");
    }
}
