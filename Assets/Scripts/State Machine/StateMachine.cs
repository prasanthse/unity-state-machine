using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine<EState> : MonoBehaviour where EState: Enum
{
    #region VARIABLES
    protected Dictionary<EState, BaseState<EState>> states = new Dictionary<EState, BaseState<EState>>();
    protected BaseState<EState> currentState;

    private bool isInTransitionState;
    #endregion

    #region UNITY CALLBACKS
    private void Start()
    {
        currentState.EnterState();
    }

    private void Update()
    {
        if (isInTransitionState) return;

        currentState.UpdateState();
    }
    #endregion

    #region STATE TRANSITION
    internal void StateTransition(EState stateKey)
    {
        isInTransitionState = true;

        currentState.ExitState();

        currentState = states[stateKey];
        currentState.EnterState();

        isInTransitionState = false;
    }
    #endregion
}