using UnityEngine;

namespace GMT.Sound
{
    [RequireComponent(typeof(AudioSource))]
    public class SoundInTrigger : MonoBehaviour
    {
        private AudioSource sound;
    
        // Use this for initialization
        private void Start()
        {
            sound = GetComponent<AudioSource>();
            sound.loop = true;
            sound.Stop();
        }

        private void OnTriggerEnter(Collider other)
        {
            sound.Play();
        }

        private void OnTriggerExit(Collider other)
        {
            sound.Pause();
        }
    }
}