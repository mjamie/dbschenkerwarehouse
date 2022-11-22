using BNG;
using HighlightPlus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof (PointerEvents))]
[RequireComponent(typeof(HighlightEffect))]
public class InteractionHighlight : MonoBehaviour
{
    public bool isHilighted = false;
    public bool meshHidden = false;

    HighlightEffect highlightEffect;
    MeshRenderer meshRenderer;
    PointerEvents pointerEvent;

    void Start()
    {
        highlightEffect = GetComponent<HighlightEffect>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void Click()
    {
        //Keep object highlighted, non-clickable and shown if hidden.
        if (isHilighted)
            return;

        isHilighted = true;

        //Add to points script.
        InteractionScore.Instance.AddScore();
    }

    public void EnterHighlight()
    {
        highlightEffect.highlighted = true;

        if (meshHidden)
            meshRenderer.enabled = true;
    }

    public void ExitHighlight()
    {
        if (isHilighted)
            return;

        highlightEffect.highlighted = false;

        if (meshHidden)
            meshRenderer.enabled = false;
    }
}
