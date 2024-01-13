using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ValueDisplay : MonoBehaviour
{
    public Slider healthBar;
    public ValueContainer valueContainer;

    void Update()
    {
        UpdateScoreText();
    }
    public void UpdateScoreText()
    {
        healthBar.value = valueContainer.value;
    }
}