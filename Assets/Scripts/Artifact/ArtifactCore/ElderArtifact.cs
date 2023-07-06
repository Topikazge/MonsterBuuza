using Assets.Scripts.Utilites.UserDebug;
using UnityEngine;
using Assets.Scripts.Artifact.Counter;

namespace Assets.Scripts.Artifact.ArtifactCore
{
    internal class ElderArtifact : MonoBehaviour
    {
        [SerializeField] private int _id;
        private AdderArtifact _adderArtifact;

        public int Id => _id;

        private void Start()
        {
            _adderArtifact = FindObjectOfType<AdderArtifact>();
            DebugMessage.NotFoundComponent<AdderArtifact>(gameObject,this, _adderArtifact);
        }

        public void PickUp()
        {
            _adderArtifact.AddFoundArtifact(this);
        }

        public void Hide()
        {

        }

        public void View()
        {

        }
    }
}
