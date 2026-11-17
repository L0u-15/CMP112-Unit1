using UnityEngine;

public class End : MonoBehaviour
{
    [SerializeField] private GameObject end;
    [SerializeField] private GameObject EndMessage;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            EndMessage.SetActive(true);
        }

    }
}
