using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Socket : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private bool shouldUnlock;

    private static int _unlockedCount = 0;
    private static int _count = 0;
    private bool _unlocked = false;
    
    #endregion

    #region XR EVENTS

    public void OnSelectEnter()
    {
        print(_unlocked);
        if (shouldUnlock && !_unlocked)
        {
            _unlocked = true;
            _unlockedCount++;
            if (_unlockedCount >= 2)
            {
                EventManager.Instance.BallPuzzleSolved();
            }
        }

        _count++;
        Debug.Log(_count + "right: " + _unlockedCount);
    }

    public void OnSelectExit()
    {
        if (shouldUnlock && _unlocked)
        {
            _unlockedCount--;
            _unlocked = false;
        }

        _count++;
        Debug.Log(_count + "right: " + _unlockedCount);
    }

    #endregion
}
