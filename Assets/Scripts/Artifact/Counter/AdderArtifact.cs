using Assets.Scripts.Utilites.UserDebug;
using UnityEngine;
using Assets.Scripts.Artifact.ArtifactCore;

namespace Assets.Scripts.Artifact.Counter
{
    internal class AdderArtifact : MonoBehaviour, ICountArtifact
    {
        private FoundElderArtifactCounter _foundElderArtifactCounter;

        private void Start()
        {
            _foundElderArtifactCounter = FindFirstObjectByType<FoundElderArtifactCounter>();
            DebugMessage.NotFoundComponent<FoundElderArtifactCounter>(gameObject, this, _foundElderArtifactCounter);      
        }

        public void AddFoundArtifact(ElderArtifact elderArtifact)
        {
            if (elderArtifact is not null)
                _foundElderArtifactCounter.AddPickUpArtifact(elderArtifact.Id);
        }
    }
}
