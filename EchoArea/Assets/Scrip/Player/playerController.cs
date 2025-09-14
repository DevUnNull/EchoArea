using UnityEngine;

[RequireComponent(typeof(PlayerStateMachine), typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private PlayerStateMachine stateMachine;
    private Rigidbody2D rb;

    void Awake()
    {
        stateMachine = GetComponent<PlayerStateMachine>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        stateMachine.ChangeState(new IdleState(stateMachine, rb));
    }
}
