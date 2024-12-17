using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    #region MONOBEHAVIOUR

    private void OnEnable()
    {
        EventManager.Instance.OnBallPuzzleSolved += Disappear;
    }

    private void OnDisable()
    {
        EventManager.Instance.OnBallPuzzleSolved -= Disappear;
    }

    #endregion

    #region HELPERS

    private void Disappear()
    {
        Destroy(this.gameObject);
    }

    #endregion
   
}
