using Assets.Scripts.Artifact.ArtifactCore;
using Assets.Scripts.Artifact.Counter;
using Assets.Scripts.Level;
using Assets.Scripts.Utilites.UserDebug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.Experimental;
using UnityEngine;

namespace Assets.Scripts.Artifact
{
    [RequireComponent(typeof(FoundElderArtifactCounter))]
    internal class ElderArtifactController : MonoBehaviour
    {
        private ElderArtifact[] _elderArtifact;
        private FoundElderArtifactCounter _foundElderArtifactCounter;
        private FirstLevelFacade _levelController;

        public  ElderArtifact[] ElderArtifacts => _elderArtifact;

        public void ElderArtifactFounded()
        {
            Debug.Log("Все артифакты собраны");
        }

        private void Start()
        {
            _foundElderArtifactCounter = GetComponent<FoundElderArtifactCounter>();
            DebugMessage.NullGetComponent<FoundElderArtifactCounter>(gameObject, this, _foundElderArtifactCounter);
            _levelController = FindObjectOfType<FirstLevelFacade>();
            DebugMessage.NotFoundComponent<FirstLevelFacade>(gameObject, this, _levelController);
            FindElderArtifact();
            _foundElderArtifactCounter.Init(SetAndReturnStatusArtifacts());
        }

        private void FindElderArtifact()
        {
            _elderArtifact = FindObjectsOfType<ElderArtifact>();
            DebugMessage.NotFoundComponents<ElderArtifact>(_elderArtifact.Length, gameObject, this);
        }

        private ArtifactStatus[] SetAndReturnStatusArtifacts()
        {
            ArtifactStatus[] artifacts = new ArtifactStatus[_elderArtifact.Length];
            for (int i = 0; i < _elderArtifact.Length; i++)
            {
                _elderArtifact[i].Id = i;
                _elderArtifact[i].PIckUpNotify += _foundElderArtifactCounter.OnPickUpArtifact;
                artifacts[i] = new ArtifactStatus(i, false);
            }
            return artifacts;
        }
    }
}
