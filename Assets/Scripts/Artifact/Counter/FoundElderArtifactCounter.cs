using Assets.Scripts.Artifact.ArtifactCore;
using Assets.Scripts.Artifact.Counter;
using Assets.Scripts.Utilites.UserDebug;
using UnityEngine;

namespace Assets.Scripts.Artifact
{
    internal class FoundElderArtifactCounter : MonoBehaviour
    {
        private ArtifactStatus[] _artifacts;
        private ElderArtifactController _elderArtifactController;

        private void Start()
        {
            _elderArtifactController = GetComponent<ElderArtifactController>();
            DebugMessage.NullGetComponent<ElderArtifactController>(gameObject,this, _elderArtifactController);
        }

        public void Init(ArtifactStatus[] artifactStatus)
        {
            DebugMessage.ObjectIsNull<ArtifactStatus>(gameObject,this, artifactStatus);
            _artifacts = artifactStatus;
        }

        public void OnPickUpArtifact(int idArtifact)
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
                _elderArtifactController.ElderArtifactFounded();
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
