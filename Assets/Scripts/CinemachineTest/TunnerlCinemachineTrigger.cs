using Unity.Cinemachine;
using UnityEngine;


public class TunnerlCinemachineTrigger : MonoBehaviour
{
    [SerializeField] private CinemachineCamera cinemachineCamera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            cinemachineCamera.Priority = 20;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cinemachineCamera.Priority = 0;
        }
    }
}
