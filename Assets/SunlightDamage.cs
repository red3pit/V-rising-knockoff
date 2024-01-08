using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SunlightDamage : MonoBehaviour
{
    public float raycastDistance = 1000f;
    public ParticleSystem sunParticleEffect;

    void Start()
    {
        if (sunParticleEffect != null)
        {
            sunParticleEffect.Stop();
        }
    }

    void Update()
    {
        GameObject sunObject = GameObject.FindGameObjectWithTag("Sun");
        if (sunObject != null)
        {
            RaycastHit hit;

            Vector3 directionToSun = (sunObject.transform.position - transform.position).normalized;
            Debug.DrawRay(transform.position, directionToSun * raycastDistance, Color.red);


            if (Physics.Raycast(transform.position, directionToSun, out hit, raycastDistance))
            {
                if (hit.collider.CompareTag("Sun"))
                {
                    SunHitAction();
                }
                else
                {
                    Debug.Log("Stop Burning1");
                    StopParticleEffect();
                }
            }
        }
    }

    void SunHitAction()
    {
        if (sunParticleEffect != null && !sunParticleEffect.isPlaying)
        {
            sunParticleEffect.Play();
            Debug.Log("Burn baby burn");
        }
    }
    void StopParticleEffect()
    {
        if (sunParticleEffect != null && sunParticleEffect.isPlaying)
        {
            sunParticleEffect.Stop();
        }
    }
}