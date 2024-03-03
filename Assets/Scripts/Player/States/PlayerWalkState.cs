using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkState : BaseState<PlayerStateMachine.PlayerState>
{
    public PlayerWalkState() : base(PlayerStateMachine.PlayerState.WALK) { }

    public override void EnterState()
    {
        Debug.Log("Player is start to be in walk state");
        PlayerManager.Instance.animationController.SetTrigger("walk");
    }

    public override void ExitState()
    {
        Debug.Log("Player is exit from walk state");
    }

    public override void UpdateState()
    {
        Debug.Log("Player is in walk state");
    }
}