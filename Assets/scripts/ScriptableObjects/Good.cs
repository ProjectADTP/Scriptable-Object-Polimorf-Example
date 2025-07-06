using UnityEngine;

public abstract class Good : ScriptableObject
{
    [SerializeField] protected string Label;
    [SerializeField] protected string Description;
    [SerializeField] protected int Price;

    public abstract void ShowInfo();
}
