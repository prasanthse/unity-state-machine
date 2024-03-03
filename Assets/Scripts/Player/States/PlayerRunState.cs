using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunState : BaseState<PlayerStateMachine.PlayerState>
{
    public PlayerRunState() : base(PlayerStateMachine.PlayerState.RUN) { }

    public override void EnterState()
    {
        Debug.Log("Player is start to be in run state");
        PlayerManager.Instance.animationController.SetTrigger("run");
    }

    public override void ExitState()
    {
        Debug.Log("Player is exit from run state");
    }

    public override void UpdateState()
    {
        Debug.Log("Player is in run state");
    }
}