using UnityEngine;

public class IdleState : IState
{
    private PlayerStateMachine _stateMachine;
    private Rigidbody2D _rb;

    public IdleState(PlayerStateMachine stateMachine, Rigidbody2D rb)
    {
        _stateMachine = stateMachine;
        _rb = rb;
    }

    public void Enter()
    {
        _rb.velocity = Vector2.zero;
        Debug.Log("Enter Idle State");
    }

    public void LogicUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 input = new Vector2(h, v);

        if (input != Vector2.zero)
        {
            if (Input.GetKey(KeyCode.LeftShift))
                _stateMachine.ChangeState(new RunState(_stateMachine, _rb));
            else
                _stateMachine.ChangeState(new WalkState(_stateMachine, _rb));
        }
    }

    public void Exit() { }
}
