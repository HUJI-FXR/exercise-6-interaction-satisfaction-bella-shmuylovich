using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CrystalBall : MonoBehaviour
{
    #region VARIABLES

    private XRGrabInteractable _grabInteractable;

    #endregion
    
    #region MONOBEHAVIOUR

    private void OnEnable()
    {
        EventManager.Instance.OnBallPuzzleSolved += Freeze;
    }

    private void OnDisable()
    {
        EventManager.Instance.OnBallPuzzleSolved -= Freeze;
    }

    private void Awake()
    {
        _grabInteractable = GetComponent<XRGrabInteractable>();
    }

    #endregion

    #region HELPERS

    private void Freeze()
    {
        _grabInteractable.enabled = false;
    }

    #endregion
}
