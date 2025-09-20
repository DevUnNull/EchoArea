using UnityEngine;

[CreateAssetMenu(fileName = "FireballCommand", menuName = "Voice Spells/Fireball")]
public class FireballCommand : VoiceSpellCommand
{
    public override string[] Keywords => new string[] { "fireball", "cầu lửa" };
}

[CreateAssetMenu(fileName = "FreezeCommand", menuName = "Voice Spells/Freeze")]
public class FreezeCommand : VoiceSpellCommand
{
    public override string[] Keywords => new string[] { "freeze", "đóng băng" };
}