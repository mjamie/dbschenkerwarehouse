using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTImer : MonoBehaviour
{
    [SerializeField]Timer timer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timer.TurnTimerOn();
        }
    }
}
