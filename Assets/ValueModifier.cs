using UnityEngine;

public class ValueModifier : MonoBehaviour
{
    public ValueContainer valueContainer;
    public int valueToAdd = 1;

    public void ModifyValue()
    {
        if (valueContainer != null)
        {
            valueContainer.AddValue(valueToAdd);
            Debug.Log($"Value modified! New value: {valueContainer.value}");
        }
        else
        {
            Debug.LogWarning("ValueContainer reference is not set!");
        }
    }
}
