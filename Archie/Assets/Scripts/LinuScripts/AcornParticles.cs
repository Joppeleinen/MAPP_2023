using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornParticles : MonoBehaviour
{
    [SerializeField] private ParticleSystem acornParticles = default;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Archie"))
        {
            Debug.Log("Archie was touched");
            acornParticles.Play();
        }
    }
}
