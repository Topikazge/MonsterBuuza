using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Buuza
{
    public class Buuza : MonoBehaviour
    {
        private NavMeshAgent _agent;
        private CharacterPlayer _characterPlayer;

        private void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
            _characterPlayer = FindFirstObjectByType<CharacterPlayer>();
        }

        private void Update()
        {
            _agent.SetDestination(_characterPlayer.transform.position);
        }
    }
}