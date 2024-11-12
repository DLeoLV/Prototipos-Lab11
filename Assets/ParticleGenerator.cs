using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleGenerator : MonoBehaviour
{
    public ParticleData particleDataTemplate;
    public GameObject particlePrefab;
    public float timeSinceLastSpawn = 0f;
    public const float spawnInterval = 0.25f;

    void Update()
    {
        float deltaTime = Time.deltaTime;
        timeSinceLastSpawn += deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnParticle();
            timeSinceLastSpawn = 0f;
        }
    }

    void SpawnParticle()
    {
        GameObject newParticle = new GameObject("Particle");
        newParticle.transform.position = transform.position;
        Particle particleScript = newParticle.AddComponent<Particle>();
        particleScript.Initialize(particleDataTemplate);
    }
}