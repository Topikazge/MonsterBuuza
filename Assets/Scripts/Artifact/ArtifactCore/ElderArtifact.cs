using Assets.Scripts.Artifact.Counter;
using Assets.Scripts.Utilites.UserDebug;
using UnityEngine;

namespace Assets.Scripts.Artifact.ArtifactCore
{
    internal class ElderArtifact : MonoBehaviour
    {
        [SerializeField] private int _id;
        private AdderArtifact _adderArtifact;

        public int Id => _id;

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void View()
        {
            gameObject.SetActive(true);
        }

        private void Start()
        {
            _adderArtifact = FindObjectOfType<AdderArtifact>();
            DebugMessage.NotFoundComponent<AdderArtifact>(gameObject, this, _adderArtifact);
        }

        public void PickUp()
        {
            _adderArtifact.AddFoundArtifact(this);
        }
    }
}
