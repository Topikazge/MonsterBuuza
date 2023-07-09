using UnityEngine;
using Assets.Scripts.Utilites.UserDebug;
using Assets.Scripts.Input.InputRead;

namespace Assets.Scripts.Input
{
    internal class InputControlCharacter : MonoBehaviour, IPlayerCharacterMovements
    {
        private PlayerInputActoins _inputActions;

        private void Start()
        {
            PlayerInputHolder playerInputHolder = FindFirstObjectByType<PlayerInputHolder>();
            DebugMessage.ErrorNullGetComponent<PlayerInputHolder>(gameObject,this, playerInputHolder);
            _inputActions = playerInputHolder.InputActions;
        }

        public Vector3 MouseDirection() => _inputActions.CharacterControl.MouseDirection.ReadValue<Vector2>();

        public Vector3 MoveDirection() => _inputActions.CharacterControl.MoveDirection.ReadValue<Vector3>();

        public bool SprintEnter() => _inputActions.CharacterControl.Sprint.enabled;
    }
}
