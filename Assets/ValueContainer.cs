using UnityEngine;

[CreateAssetMenu(fileName = "New Value Container", menuName = "ScriptableObjects/Value Container", order = 1)]
public class ValueContainer : ScriptableObject
{
    public int value;


    public void ResetValue(int amount)
    {
        value = 100;
    }

    public void AddValue(int amount)
    {
        value += amount;
    }
}