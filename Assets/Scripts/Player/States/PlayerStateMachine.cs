using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine<PlayerStateMachine.PlayerState>, ITriggerState
{
    #region VARIABLES
    public enum PlayerState
    {
        IDLE,
        WALK,
        RUN,
        ATTACK,
        DEATH
    }
    #endregion

    #region UNITY CALLBACKS
    private void Awake()
    {
        states.Add(PlayerState.IDLE, new PlayerIdleState());
        states.Add(PlayerState.WALK, new PlayerWalkState());
        states.Add(PlayerState.RUN, new PlayerRunState());
        states.Add(PlayerState.ATTACK, new PlayerAttackState());
        states.Add(PlayerState.DEATH, new PlayerDeathState());
        
        currentState = states[PlayerState.IDLE];
    }

    public void OnTriggerEnter(Collider other)
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        
    }

    public void OnTriggerExist(Collider other)
    {

    }
    #endregion

    #region STATE TRANSITION
    internal void SwitchState(PlayerState nextState)
    {
        StateTransition(nextState);
    }
    #endregion
}