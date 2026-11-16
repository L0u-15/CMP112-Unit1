using NUnit.Framework;
using System.Xml.Serialization;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool IsDoorOpen = false;
    [SerializeField] 
    private int requiredSwitchesToOpen = 1;
    [SerializeField] 
    private Animator animator;
    private List<PressurePlate> currentSwitchesOpen = new();
    public int CurrentSwitchesOpen => currentSwitchesOpen.Count;
    private void start()
    {
        IsDoorOpen = false;
        animator.Play("DoorClose");
    }
    public void AddPressurePlate(PressurePlate currentSwitch)
    {
        if (!currentSwitchesOpen.Contains(currentSwitch))
        {
            currentSwitchesOpen.Add(currentSwitch);
        }
        TryOpen();
    }
    public void RemovePressurePlate(PressurePlate currentSwitch)
    {
        if (currentSwitchesOpen.Contains(currentSwitch))
        {
            currentSwitchesOpen.Remove(currentSwitch);
        }
        TryOpen();
    }
    private void TryOpen()
    {
        if (CurrentSwitchesOpen == requiredSwitchesToOpen)
        {
            OpenDoor();
        }else if(CurrentSwitchesOpen < requiredSwitchesToOpen)
        {
            CloseDoor();
        }
    }
    private void CloseDoor()
    {
        
        if (IsDoorOpen)
        {
            animator.Play("DoorClose");

        }
        IsDoorOpen = false;

    }
    private void OpenDoor()
    {
        
        if (!IsDoorOpen)
        {
            animator.Play("DoorOpen");

        }
        IsDoorOpen = true;

    }
}
