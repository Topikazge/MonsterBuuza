using Assets.Scripts.Level;
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
        private CharacterPlayer _character;
        private IRestart _level;

        private void Start()
        {
            _character = FindObjectOfType<CharacterPlayer>();
            DebugMessage.NotFoundComponent<CharacterPlayer>(gameObject,this, _character);
            _level = FindObjectOfType<LevelBase>();
            DebugMessage.NotFoundComponent<LevelBase>(gameObject, this, (LevelBase)_level);
        }

        public void PlayerDied()
        {
            _level.Restart();
        }
    }
}
