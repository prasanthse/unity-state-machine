using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    #region VARIABLES
    public static PlayerManager Instance { get; private set; }

    public Animator animationController;
    [SerializeField] private PlayerStateMachine playerStateMachine;
    #endregion

    #region UNITY CALLBACKS
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    #endregion

    #region BEHAVIORS
    public void Idle()
    {
        playerStateMachine.SwitchState(PlayerStateMachine.PlayerState.IDLE);
    }

    public void Walk()
    {
        playerStateMachine.SwitchState(PlayerStateMachine.PlayerState.WALK);
    }

    public void Run()
    {
        playerStateMachine.SwitchState(PlayerStateMachine.PlayerState.RUN);
    }

    public void Attack()
    {
        playerStateMachine.SwitchState(PlayerStateMachine.PlayerState.ATTACK);
    }

    public void Death()
    {
        playerStateMachine.SwitchState(PlayerStateMachine.PlayerState.DEATH);
    }
    #endregion
}