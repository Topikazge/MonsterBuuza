using Assets.Scripts.Artifact.ArtifactCore;
using Assets.Scripts.Character;
using Assets.Scripts.Utilites.UserDebug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Buuza
{
    internal class BuuzaCollisison : MonoBehaviour
    {
        private Buuza _buuza;

        private void Start()
        {
            _buuza = GetComponent<Buuza>();
            DebugMessage.NotFoundComponent<Buuza>(gameObject,this, _buuza);
        }
        private void OnTriggerEnter(Collider collision)
        {
            Debug.Log(collision.gameObject.name);
            if (TryFind<CharacterPlayerBase>(collision.gameObject))
            {
                collision.gameObject.GetComponent<CharacterPlayerBase>().Hit();
            }
        }

        private bool TryFind<T>(GameObject target) where T : MonoBehaviour
        {
            return target.TryGetComponent(out T character) ? true : false;
        }
    }
}
