using Assets.Scripts.Utilites.UserDebug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Artifact.ArtifactCore
{
    internal class ArtifactCollision : MonoBehaviour
    {
        private ElderArtifact _elderArtifact;

        private void Start()
        {
            _elderArtifact = GetComponent<ElderArtifact>();
            DebugMessage.ErrorNullGetComponent<ElderArtifact>(gameObject,this, _elderArtifact);
        }

        private void OnTriggerEnter(Collider collision)
        {
            Debug.Log(collision.gameObject.name);
            if (TryFind<CharacterPlayer>(collision.gameObject))
            {
                _elderArtifact.PickUp();
            }
        }

        private bool TryFind<T>(GameObject target) where T : MonoBehaviour
        {
            return target.TryGetComponent(out T scoreZone) ? true : false;
        }
    }
}
