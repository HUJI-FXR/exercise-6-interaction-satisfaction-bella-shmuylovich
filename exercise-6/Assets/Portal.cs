using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Portal : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private Transform otherPortal;

    private TeleportationArea _teleportationArea;

    #endregion

    #region MONOBEHAVIOUR

    private void OnEnable()
    {
        EventManager.Instance.OnBallPuzzleSolved += EnableTeleport;
    }

    private void OnDisable()
    {
        EventManager.Instance.OnBallPuzzleSolved -= EnableTeleport;
    }

    private void Awake()
    {
        _teleportationArea = GetComponent<TeleportationArea>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Vector3.Distance(other.transform.position, transform.position) > 0.3f)
        {
            Debug.Log("ENTERED PORTAL");
            other.transform.position = new Vector3(otherPortal.position.x, transform.position.y, otherPortal.position.z);
        }
    }

    #endregion

    #region HELPERS

    private void EnableTeleport()
    {
        _teleportationArea.enabled = true;
    }

    #endregion
}
