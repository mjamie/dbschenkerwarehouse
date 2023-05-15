using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractionScore : GenericSingletonClass<InteractionScore>
{
    [SerializeField] List <TextMeshProUGUI> text;
    
    [SerializeField] int initialScore = 0;

    [SerializeField] int maxScore = 10;
    [SerializeField] BoxCollider exitCollider;
    [SerializeField] GameObject alarmLights;
    [SerializeField] GameObject smoke;

    [SerializeField] TextMeshProUGUI exitText;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void AddScore()
    {
        ++initialScore;
        foreach (var text in text)
        {
            text.text = initialScore + "/" + maxScore;
        }

        if (initialScore >= maxScore)
        {
            audioSource.Play();

            StartCoroutine(HideText());

            exitCollider.enabled = true;
            alarmLights.SetActive(true);
            smoke.SetActive(true);
            Debug.Log("EXIT THE WAREHOUSE");
        }
    }

    IEnumerator HideText()
    {
        exitText.enabled = true;
        yield return new WaitForSeconds(3);
        exitText.enabled = false;
    }
}
