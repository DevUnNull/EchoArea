using UnityEngine;

public class WalkState : IState
{
    private PlayerStateMachine _stateMachine;
    private Rigidbody2D _rb;
    private float speed = 3f;

    public WalkState(PlayerStateMachine stateMachine, Rigidbody2D rb)
    {
        _stateMachine = stateMachine;
        _rb = rb;
    }

    public void Enter()
    {
        Debug.Log("Enter Walk State");
    }

    public void LogicUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 input = new Vector2(h, v).normalized;

        if (input == Vector2.zero)
        {
            _stateMachine.ChangeState(new IdleState(_stateMachine, _rb));
            return;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _stateMachine.ChangeState(new RunState(_stateMachine, _rb));
            return;
        }

        _rb.velocity = input * speed;
    }

    public void Exit() { }
}
