using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    #region VARIABLES

    public static EventManager Instance { get; private set; }
    
    public event Action OnBallPuzzleSolved;
    public event Action OnBookPuzzleSolved;
    
    #endregion
    
    #region MONOBEHAVIOUR

    private void OnEnable()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    
    #endregion
    
    #region API

    public void BallPuzzleSolved()
    {
        Debug.Log("BALL PUZZLE SOLVED");
        OnBallPuzzleSolved?.Invoke();
    }
    
    public void BookPuzzleSolved()
    {
        Debug.Log("BOOK PUZZLE SOLVED");
        OnBookPuzzleSolved?.Invoke();
    }

    #endregion
   
}
