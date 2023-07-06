using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Input
{
    public class PlayerInputHolder : MonoBehaviour
    {
        private PlayerInputActoins _inputActions;

        public PlayerInputActoins InputActions => _inputActions;

        private void Awake()
        {
            _inputActions = new PlayerInputActoins();
        }

        private void OnDisable()
        {
            _inputActions.Disable();
        }

        private void OnEnable()
        {
            _inputActions.Enable();
        }
    }
}
