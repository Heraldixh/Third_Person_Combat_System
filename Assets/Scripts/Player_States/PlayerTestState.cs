using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestState : PlayerBaseState
{
    public PlayerTestState(PlayerStateMachine stateMachine) : base(stateMachine)
    {

    }

    public override void Enter()
    {
        Debug.Log("Entering State");
    }

    public override void Exit()
    {
        Debug.Log("Exiting State");
    }

    public override void Tick(float deltaTime)
    {
        Vector3 movement = new Vector3();
        movement.x = stateMachine.inputReader.MovementValue.x;
        movement.y = 0;
        movement.z = stateMachine.inputReader.MovementValue.y;

        stateMachine.transform.Translate(movement * deltaTime);

    }

}
