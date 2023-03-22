using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/String Event Channel", order = 0)]
public class StringEventChannel : ScriptableObject
{
    public Action<String> OnEventRaised;

    public void RaiseEvent(String value)
    {
        OnEventRaised?.Invoke(value);
    }
}