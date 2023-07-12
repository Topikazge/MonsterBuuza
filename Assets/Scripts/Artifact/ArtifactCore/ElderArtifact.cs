using Assets.Scripts.Artifact.Counter;
using Assets.Scripts.Utilites.UserDebug;
using System;
using UnityEngine;

namespace Assets.Scripts.Artifact.ArtifactCore
{
    internal class ElderArtifact : MonoBehaviour
    {
        public int Id { get; set; }

        public event Action<int> PIckUpNotify;

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void View()
        {
            gameObject.SetActive(true);
        }

        public void PickUp()
        {
            Hide();
            PIckUpNotify.Invoke(Id);
        }
    }
}
