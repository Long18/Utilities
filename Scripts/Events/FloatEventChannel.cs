using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/Float Event Channel", order = 0)]
public class FloatEventChannel : ScriptableObject
{
    public Action<float> OnEventRaised;

    public void RaiseEvent(float value)
    {
        OnEventRaised?.Invoke(value);
    }
}