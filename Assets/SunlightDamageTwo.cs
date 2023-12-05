using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEditor.Rendering.CameraUI;

public class SunlightDamageTwo : MonoBehaviour
{
    public float brightnessThreshold = 1.0f;

    void Update()
    {
        // Get the position of the player
        Vector3 playerPosition = transform.position;

        // Sample the light probe data at the player's position
        float[] lightProbeData = LightmapSettings.lightProbes.GetInterpolatedProbe(playerPosition, null, out Rendering.SphericalHarmonicsL2 probe);

        // Calculate the average brightness from the light probe data
        float averageBrightness = (lightProbeData[0] + lightProbeData[1] + lightProbeData[2]) / 3.0f;

        // Check the brightness value and trigger events accordingly
        if (averageBrightness > brightnessThreshold)
        {
            Debug.Log("Burning");
        }
        else
        {
            Debug.Log("Not burning");
        }
    }
}