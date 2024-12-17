using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    #region MONOBEHAVIOUR

    private void OnEnable()
    {
        EventManager.Instance.OnBookPuzzleSolved += Disappear;
    }

    private void OnDisable()
    {
        EventManager.Instance.OnBookPuzzleSolved -= Disappear;
    }

    #endregion

    #region HELPERS

    private void Disappear()
    {
        Destroy(this.gameObject);
    }

    #endregion
   
}
