using UnityEngine;

namespace HassakuLab.AudioMastering
{
    /// <summary>
    /// AudioClip that volume is controlled
    /// </summary>
    [CreateAssetMenu(fileName = "NewClip", menuName = "AudioMastering/Clip", order = 0)]
    public class VolumeControlledAudioClip : ScriptableObject
    {
        /// <summary>
        /// reference to AudioClip
        /// </summary>
        [SerializeField] private AudioClip audioClip;
        
        /// <summary>
        /// volume for this clip
        /// </summary>
        [SerializeField] [Range(0f, 1f)] private float volume = 1;

        /// <summary>
        /// get or set AudioClip reference
        /// </summary>
        public AudioClip AudioClip
        {
            get => audioClip;
            set => audioClip = value;
        }

        /// <summary>
        /// get or set volume for this clip
        /// </summary>
        public float Volume
        {
            get => volume;
            set => volume = value;
        }
    }
}