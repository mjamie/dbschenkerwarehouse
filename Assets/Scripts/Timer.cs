using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public List<TextMeshProUGUI> TimerTxt;

    [SerializeField] TextMeshProUGUI outOfTImeTxt;
    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("Time is UP!");
                TimeLeft = 0;
                TimerOn = false;
                outOfTImeTxt.enabled = true;

                StartCoroutine(Restart());

                IEnumerator Restart()
                {
                    yield return new WaitForSeconds(10);
                    SceneManager.LoadScene(0);
                }
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        foreach (var text in TimerTxt)
        {
            text.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public void TurnTimerOn() => TimerOn = true;

}
