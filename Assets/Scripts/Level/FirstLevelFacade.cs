using Assets.Scripts.Buuza;
using Assets.Scripts.Character;
using UnityEngine;

namespace Assets.Scripts.Level
{
    internal class FirstLevelFacade : LevelBase
    {
        private CharacterPlayerController _playerController;
        private BuuzaFacade _buuzaController;

        public override void Restart()
        {
            Debug.Log("рЕСТАРТ");
        }
    }
}
