using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ValueDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public ValueContainer valueContainer;

    void Update()
    {
        UpdateScoreText();
    }
    public void UpdateScoreText()
    {
        scoreText.text = "" + valueContainer.value.ToString();
    }
}