using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public ParticleData data;
    public float remainingLifetime;
    public SpriteRenderer spriteRenderer;
    public static readonly Vector2 direction = Vector2.up;
    public float randomXSpeed;

    public void Initialize(ParticleData particleData)
    {
        data = particleData;
        remainingLifetime = ParticleData.lifetime;
        randomXSpeed = Random.Range(-33f, 33f);
        spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = Sprite.Create(data.image, new Rect(0.0f, 0.0f, data.image.width, data.image.height), new Vector2(0.5f, 0.5f), 100.0f);
    }

    void Update()
    {
        float deltaTime = Time.deltaTime;
        transform.position += new Vector3(randomXSpeed * deltaTime, data.velocity.y * deltaTime, 0);
        remainingLifetime -= deltaTime;
        if (remainingLifetime <= 0)
        {
            Destroy(gameObject);
        }
    }
}