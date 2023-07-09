using Assets.Scripts.Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Buuza
{
    public class Buuza : MonoBehaviour
    {
        private NavMeshAgent _agent;
        private CharacterPlayerBase _characterPlayer;

        private void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
            _characterPlayer = FindFirstObjectByType<CharacterPlayer>();
        }

        private void Update()
        {
            SetTargetToMove();
        }

        private void SetTargetToMove()
        {
            _agent.SetDestination(_characterPlayer.transform.position);
        }

        public void OnCollisionWithCharacter(Collision collision)
        {
            _characterPlayer.Hit();
        }
    }
}