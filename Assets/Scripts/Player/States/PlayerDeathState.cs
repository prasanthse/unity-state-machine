using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathState : BaseState<PlayerStateMachine.PlayerState>
{
    public PlayerDeathState() : base(PlayerStateMachine.PlayerState.DEATH) { }

    public override void EnterState()
    {
        Debug.Log("Player is start to be in death state");
        PlayerManager.Instance.animationController.SetTrigger("death");
    }

    public override void ExitState()
    {
        Debug.Log("Player is exit from death state");
    }

    public override void UpdateState()
    {
        Debug.Log("Player is in death state");
    }
}