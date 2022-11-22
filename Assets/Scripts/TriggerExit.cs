using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerExit : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] AudioSource siren;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.gameObject.SetActive(true);
            siren.Stop();
        }
    }
}
