using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FallingBook : MonoBehaviour
{

    #region VARIABLES

    [SerializeField] private Vector3 fallingForce;

    private Rigidbody _rigidbody;

    #endregion
    
    #region MONOBEHAVIOUR

    private void OnEnable()
    {
        EventManager.Instance.OnBookPuzzleSolved += Fall;
    }

    private void OnDisable()
    {
        EventManager.Instance.OnBookPuzzleSolved -= Fall;
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    #endregion

    #region HELPERS

    private void Fall()
    {
        _rigidbody.AddForce(fallingForce, ForceMode.Impulse);
    }

    #endregion
}
