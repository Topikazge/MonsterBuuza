using Assets.Scripts.Artifact.ArtifactCore;
using Assets.Scripts.Artifact.Counter;
using Assets.Scripts.Utilites.UserDebug;
using UnityEngine;

namespace Assets.Scripts.Artifact
{
    [RequireComponent(typeof(AdderArtifact))]
    internal class FoundElderArtifactCounter : MonoBehaviour
    {
        private ArtifactStatus[] _artifacts;

        private void Start()
        {
            ElderArtifact[] elderArtifacts = FindObjectsOfType<ElderArtifact>();
            _artifacts = new ArtifactStatus[elderArtifacts.Length];
            DebugMessage.NotFoundComponents<ElderArtifact>(elderArtifacts.Length, gameObject, this);
            for (int i = 0; i < elderArtifacts.Length; i++)
            {
                _artifacts[i] = new ArtifactStatus(elderArtifacts[i].Id,false);
            }
        }

        public void AddPickUpArtifact(int idArtifact)
        {
            foreach (var item in _artifacts)
            {
                if (item.Id == idArtifact)
                {
                    item.IsFound = true;
                }
            }
            if (IsFoundAllArtifact())
            {
                Debug.LogError("Уведомления");
            }
        }

        private bool IsFoundAllArtifact()
        {
            foreach (var artifact in _artifacts)
            {
                if(artifact.IsFound == false)
                    return false;
            }
            return true;
        }
    }
}
