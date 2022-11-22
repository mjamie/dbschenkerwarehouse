using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class NPCLookTrigger : MonoBehaviour
{
    [SerializeField] MultiAimConstraint multiAimConstraint;
    [SerializeField] RigBuilder rigBuilder;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            multiAimConstraint.weight = 1;
            rigBuilder.Build();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //multiAimConstraint.weight = 0;
           // rigBuilder.Build();
        }
    }
}
