using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : BaseState<PlayerStateMachine.PlayerState>
{
    public PlayerIdleState() : base(PlayerStateMachine.PlayerState.IDLE) { }

    public override void EnterState()
    {
        Debug.Log("Player is start to be in idle state");
        PlayerManager.Instance.animationController.SetTrigger("idle");
    }

    public override void ExitState()
    {
        Debug.Log("Player is exit from idle state");
    }

    public override void UpdateState()
    {
        Debug.Log("Player is in idle state");
    }
}