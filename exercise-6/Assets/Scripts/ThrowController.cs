using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ThrowController : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private Transform headTransform;

    private XRDirectInteractor _directInteractor;
    private GameObject _selected;

    #endregion

    #region MONOBEHAVIOUR

    private void Awake()
    {
        _directInteractor = GetComponent<XRDirectInteractor>();
    }

    #endregion

    #region XR

    public void OnSelectEnter()
    {
        _selected = _directInteractor.interactablesSelected[0].transform.gameObject;
    }

    public void OnSelectExit()
    {
        if (_selected == null) return;
        Vector3 throwVec = (transform.position - headTransform.position).normalized;
        _selected.GetComponent<Rigidbody>().AddForce(throwVec, ForceMode.Impulse);
    }

    #endregion
}
