using UnityEngine;

namespace HassakuLab.AudioMastering
{
    /// <summary>
    /// component for playing VolumeControlledAudioClip
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class VolumeControlledAudioSource : MonoBehaviour
    {
        /// <summary>
        /// audio clip that volume is controlled
        /// </summary>
        [SerializeField] private VolumeControlledAudioClip clip;
        
        /// <summary>
        /// volume for change
        ///
        /// do not change AudioSource.volume directly
        /// </summary>
        [SerializeField] [Range(0f, 1f)] private float volume;

        /// <summary>
        /// get or set volume
        /// </summary>
        public float Volume
        {
            get => volume;
            set => volume = value;
        }

        private void UpdateAudioSource(AudioSource source)
        {
            source.clip = clip.AudioClip;
            source.volume = volume * clip.Volume;
        }

        /// <summary>
        /// on add component
        /// </summary>
        private void Reset()
        {
            volume = GetComponent<AudioSource>().volume;
        }

        /// <summary>
        /// on value change in inspector
        /// </summary>
        private void OnValidate()
        {
            UpdateAudioSource(GetComponent<AudioSource>());
        }
    }
}