using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class VoiceSpellManager : MonoBehaviour
{
    private KeywordRecognizer recognizer;
    private Dictionary<string, IVoiceCommand> commandMap;

    public List<VoiceSpellCommand> voiceCommands;

    void Start()
    {
        commandMap = new Dictionary<string, IVoiceCommand>();
        var keywordList = new List<string>();

        foreach (var command in voiceCommands)
        {
            // Không cần gọi SetParameters nữa, các prefab và shootPoint
            // đã được gán trực tiếp trên từng ScriptableObject
            foreach (var keyword in command.Keywords)
            {
                commandMap[keyword] = (IVoiceCommand)command;
                keywordList.Add(keyword);
            }
        }

        if (keywordList.Any())
        {
            recognizer = new KeywordRecognizer(keywordList.ToArray(), ConfidenceLevel.Medium);
            recognizer.OnPhraseRecognized += OnPhraseRecognized;
            recognizer.Start();
        }
    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        if (commandMap.TryGetValue(args.text, out var command))
        {
            command.Execute();
        }
    }

    void OnDestroy()
    {
        if (recognizer != null)
        {
            if (recognizer.IsRunning) recognizer.Stop();
            recognizer.OnPhraseRecognized -= OnPhraseRecognized;
            recognizer.Dispose();
        }
    }
}