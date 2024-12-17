using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Socket : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private bool shouldUnlock;

    private static int _unlockedCount = 0;

    #endregion

    #region XR EVENTS

    public void OnSelectEnter()
    {
        if (shouldUnlock)
        {
            _unlockedCount++;
            if (_unlockedCount >= 2)
            {
                EventManager.Instance.BallPuzzleSolved();
            }
        }
    }

    public void OnSelectExit()
    {
        if (shouldUnlock)
        {
            _unlockedCount--;
        }
    }

    #endregion
}
