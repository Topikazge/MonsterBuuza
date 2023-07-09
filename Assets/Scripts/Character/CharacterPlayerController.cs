using Assets.Scripts.Utilites.UserDebug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts.Character
{
    internal class CharacterPlayerController : MonoBehaviour
    {
        private CharacterPlayer _characterPlayer;

        private void Start()
        {
            _characterPlayer = FindObjectOfType<CharacterPlayer>();
            DebugMessage.NotFoundComponent<CharacterPlayer>(gameObject,this, _characterPlayer);
        }
        public void PlayerDied()
        {
            Debug.LogError("Игрок умер");
        }
    }
}
