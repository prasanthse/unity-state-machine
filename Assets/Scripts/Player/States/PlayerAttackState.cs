using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackState : BaseState<PlayerStateMachine.PlayerState>
{
    public PlayerAttackState() : base(PlayerStateMachine.PlayerState.ATTACK) { }

    public override void EnterState()
    {
        Debug.Log("Player is start to be in attack state");
        PlayerManager.Instance.animationController.SetTrigger("attack");
    }

    public override void ExitState()
    {
        Debug.Log("Player is exit from attack state");
    }

    public override void UpdateState()
    {
        Debug.Log("Player is in attack state");
    }
}