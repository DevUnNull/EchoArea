public interface IVoiceCommand
{
    string[] Keywords { get; }
    void Execute();
}