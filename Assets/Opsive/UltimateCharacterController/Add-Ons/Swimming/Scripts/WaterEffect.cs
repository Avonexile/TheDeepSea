/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

using UnityEngine;
using Opsive.UltimateCharacterController.Game;
using Opsive.UltimateCharacterController.Utility;

namespace Opsive.UltimateCharacterController.AddOns.Swimming
{
    /// <summary>
    /// Stores and plays a water effect at the specified location.
    /// </summary>
    public class WaterEffect
    {
        [Tooltip("The prefab of the particle that should play.")]
        [SerializeField] protected GameObject m_ParticlePrefab;
        [Tooltip("The location that the particle should play.")]
        [SerializeField] protected Transform m_Location;
        [Tooltip("The audio that should play when the effect plays.")]
        [SerializeField] protected Audio.AudioClipSet m_AudioClipSet;

        public GameObject ParticlePrefab { get { return m_ParticlePrefab; } }

        private ParticleSystem m_Particles;
        private bool m_Continuous;
        private bool m_Playing;

        public bool Continuous { set { m_Continuous = value; } }
        public bool IsPlaying { get { return m_Playing; } }

        /// <summary>
        /// Plays the effect.
        /// </summary>
        public virtual void Play()
        {
            if (m_Location == null) {
                return;
            }

            Play(m_Location.position);
        }

        /// <summary>
        /// Plays the effect at the specified position.
        /// </summary>
        /// <param name="position">The position to play the effect.</param>
        public void Play(Vector3 position)
        {
            if (m_ParticlePrefab == null) {
                return;
            }

            // Continuous effects will persist on the character and have to be stopped manually.
            if (!m_Continuous || m_Particles == null) {
                var instantiatedParticles = ObjectPool.Instantiate(m_ParticlePrefab, position, m_ParticlePrefab.transform.rotation);
                if (m_Continuous) {
                    instantiatedParticles.transform.parent = m_Location;
                    m_Particles = instantiatedParticles.GetCachedComponent<ParticleSystem>();
                }
            }

            m_Playing = true;
            if (m_Particles != null) {
                m_Particles.Play();
            }
            
            m_AudioClipSet.PlayAtPosition(position);
        }

        /// <summary>
        /// Stops the effect. Only applies to continuous effects.
        /// </summary>
        public void Stop()
        {
            m_Playing = false;
            if (m_Particles != null) {
                m_Particles.Stop();
            }
        }
    }

    /// <summary>
    /// Inherits WaterEffect allowing a splash to be played based on an event.
    /// </summary>
    public class WaterEffectEventDistance : WaterEffect
    {
        [Tooltip("The name of the event that should play the effect.")]
        [SerializeField] protected string m_EventName;
        [Tooltip("The maximum distance that the location transform can be away from the water collider.")]
        [SerializeField] protected float m_MaxColliderDistance = 0.4f;

        public string EventName { get { return m_EventName; } }
        public System.Action OnEvent { get { return () => { Play(); }; } }

        private Swim m_SwimAbility;

        /// <summary>
        /// Initializes the object.
        /// </summary>
        /// <param name="swimAbility">A reference to the swim ability.</param>
        public void Initialize(Swim swimAbility)
        {
            m_SwimAbility = swimAbility;
        }

        /// <summary>
        /// Plays the effect.
        /// </summary>
        public override void Play()
        {
            // The event may be called when the limb is too far away from the surface of the water collider.
            if (m_SwimAbility.GetDepthInWater(m_Location) > m_MaxColliderDistance) {
                return;
            }

            base.Play();
        }
    }

    /// <summary>
    /// Inherits WaterEffect allowing a minimum velocity to be specified that limits when the splash can be played.
    /// </summary>
    public class WaterEffectVelocity : WaterEffect
    {
        [Tooltip("The minimum velocity that the character must be moving at in order for the effect to be played.")]
        [SerializeField] protected float m_MinVelocity;

        public float MinVelocity { get { return m_MinVelocity; } }
    }
}