using System;
using UnityEngine;

namespace UniteScripts
{
    [RequireComponent(typeof(Collider))]
    public class Collectable : MonoBehaviour
    {
        [SerializeField] LayerMask layers;
        [SerializeField] GameObject m_CollectEffect;
        [SerializeField] AudioClip m_CollectAudio;
        [SerializeField] bool m_DisableOnCollect = false;

        /// <summary>
        /// Create the Logic that should happen when the Player Collects the Collectable
        /// </summary>
        void ImplementOwnCollectLogic()
        {
            throw new NotImplementedException();
        }

        void Reset()
        {
            Collider collider = GetComponent<Collider>();
            collider.isTrigger = true;
        }

        void OnTriggerEnter(Collider other)
        {
            if (CanCollect(other))
                Collect();
        }

        void Collect()
        {
            //Implement your Own Logic
            ImplementOwnCollectLogic();

            if (m_CollectEffect)
                Instantiate(m_CollectEffect, this.transform.position, Quaternion.identity);

            if (m_CollectAudio)
            {
                //Create a Audio Source GameObject at Runtime, Change this with prefered Audio System.
                GameObject go = new GameObject("Collect Sound");
                AudioSource cAudio = go.AddComponent<AudioSource>();
                cAudio.clip = m_CollectAudio;
                cAudio.Play();
                Destroy(go, m_CollectAudio.length);
            }

            if (m_DisableOnCollect)
            {
                gameObject.SetActive(false);
                return;
            }

            //If we aren't Disable the Collectable we gonna Destroy it
            Destroy(this.gameObject);
        }

        bool CanCollect(Collider other)
        {
            return 0 != (layers.value & 1 << other.gameObject.layer);
        }

    }
}
