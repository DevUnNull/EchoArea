public interface IState
{
    void Enter();         // khi bắt đầu state
    void LogicUpdate();   // gọi mỗi frame
    void Exit();          // khi rời khỏi state
}
