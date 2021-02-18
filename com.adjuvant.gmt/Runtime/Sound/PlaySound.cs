using UnityEngine;

namespace GMT.Sound
{
    [RequireComponent(typeof(AudioSource))]
    public class PlaySound : MonoBehaviour
    {
        public AudioClip soundToPlay;
        private AudioSource _audioSource;

        private void OnEnable()
        {
            _audioSource = GetComponent<AudioSource>();
            if(!soundToPlay && !_audioSource.clip) Debug.LogError("This play script needs at least one audio clip.");
        }

        public void PlayNow()
        {
            if(_audioSource.isPlaying) _audioSource.Stop();
            if(soundToPlay)
                _audioSource.clip = soundToPlay;
            _audioSource.Play();
        }
    }
}
