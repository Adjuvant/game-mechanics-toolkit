using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundOnCollision : MonoBehaviour
{
    private AudioSource sound;

    // Use this for initialization
    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        sound.pitch = Random.Range(0.76f, 1.35f);
        sound.PlayOneShot(sound.clip,Random.Range(0.85f,1f));
        
    }
}