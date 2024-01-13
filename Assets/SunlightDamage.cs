using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SunlightDamage : MonoBehaviour
{
    public Transform sun;
    public ParticleSystem sunParticleEffect;
    public GameObject player;
    public ValueContainer health;
    private int damage = 5;
    private int regeneration = 1;
    public float regenerationTime = 1f;

    void Start()
    {
        if (sunParticleEffect != null)
        {
            sunParticleEffect.Stop();
        }
    }
    // light transform.forward jak okierunek ray

    void Update()
    {

        Vector3 sunDirection = sun.forward;
        Ray ray = new Ray(transform.position, -sunDirection);
        Debug.DrawRay(ray.origin, ray.direction * 10f, Color.red);

        if (!Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
        {
            // The ray didn't hit anything, trigger your desired action here
            SunHitAction();
        }
        else
        {
            Debug.Log("Stop Burning1");
            StopParticleEffect();
            Regenerate();
        }

    }

    void SunHitAction()
    {
        if (sunParticleEffect != null && !sunParticleEffect.isPlaying)
        {
            sunParticleEffect.Play();
            BurnDamage();
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

    void BurnDamage()
    {
        if (health.value > 0)
        {
            health.AddValue(-damage);
        }
        else
        {
            player.SetActive(false);
        }

    }

    void Regenerate()
    {
        if (health.value<100)
        {
            health.AddValue(regeneration);
        }

    }
}