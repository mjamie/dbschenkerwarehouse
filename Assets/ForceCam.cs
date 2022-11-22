using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceCam : MonoBehaviour
{
    [SerializeField] Camera centerCamera;
    Canvas canvas;
    void Start()
    {
        canvas = GetComponent<Canvas>();

        if (canvas.worldCamera != centerCamera)
            canvas.worldCamera = centerCamera;

    }

    // Update is called once per frame
    void Update()
    {
        if (canvas.worldCamera != centerCamera)
            canvas.worldCamera = centerCamera;
    }
}
