using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CrystalBall : MonoBehaviour
{
    #region VARIABLES

    private XRGrabInteractable _grabInteractable;
    private Rigidbody _rigidbody;

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
        _rigidbody = GetComponent<Rigidbody>();
    }

    #endregion

    #region API

    public void Throw()
    {
        Debug.Log("throw");
        _rigidbody.AddForce(Vector3.up);
    }

    #endregion

    #region HELPERS

    private void Freeze()
    {
        _rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        _grabInteractable.enabled = false;
    }

    #endregion
}
