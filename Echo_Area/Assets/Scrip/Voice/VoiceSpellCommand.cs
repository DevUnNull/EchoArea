using UnityEngine;

public abstract class VoiceSpellCommand : ScriptableObject // Đảm bảo nó kế thừa từ ScriptableObject
{
    public abstract string[] Keywords { get; }

    [SerializeField]
    protected GameObject prefab;
    [SerializeField]
    protected Transform shootPoint; // Thêm trường shootPoint vào đây

    public virtual void Execute()
    {
        if (prefab != null && shootPoint != null)
        {
            MonoBehaviour.Instantiate(prefab, shootPoint.position, shootPoint.rotation);
            Debug.Log($"Casting {Keywords[0]}");
        }
    }
}