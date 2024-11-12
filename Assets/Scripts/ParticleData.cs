using UnityEngine;

[CreateAssetMenu(fileName = "ParticleData", menuName = "ScriptableObjects/ParticleData", order = 1)]
public class ParticleData : ScriptableObject
{
    public Vector2 velocity;
    public Texture2D image;
    public const float lifetime = 3.0f;
}