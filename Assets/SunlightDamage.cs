using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SunlightDamage : MonoBehaviour
{
    public Transform playerTransform;
    public float sunDamage = 10f;

    void Update()
    {

        float lightIntensity = GetLightIntensityAtPlayer();

        // Check if the light intensity is above a certain threshold
        if (lightIntensity > 0.5f)
        {
            // Player is exposed to sunlight
            ApplySunDamage();
        }
    }

    float GetLightIntensityAtPlayer()
    {
        // Sample the light probe data at the player's position
        Vector3 playerPosition = playerTransform.position;
        float[] coefficients = new float[3];
        //LightProbes.GetInterpolatedProbe(playerPosition, null , out coefficients);

        // Calculate the average intensity from the lighting data
        float lightIntensity = CalculateAverageIntensity(coefficients);

        return lightIntensity;
    }

    float CalculateAverageIntensity(float[] coefficients)
    {
        // Calculate the average intensity from the coefficients
        float sum = 0f;
        for (int i = 0; i < coefficients.Length; i++)
        {
            sum += coefficients[i];
        }

        float averageIntensity = sum / coefficients.Length;
        return averageIntensity;
    }

    void ApplySunDamage()
    {
 
    }
}