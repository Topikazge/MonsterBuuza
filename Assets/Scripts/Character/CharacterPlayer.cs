using Assets.Scripts.Character;
using Assets.Scripts.Input;
using Assets.Scripts.Input.InputRead;
using Assets.Scripts.Utilites.UserDebug;
using UnityEngine;

namespace Assets.Scripts.Character
{
    internal class CharacterPlayer : CharacterPlayerBase
    {
        [SerializeField] private float _walkingSpeed = 7.5f;
        [SerializeField] private float _runningSpeed = 11.5f;
        //[SerializeField] private float _jumpSpeed = 8.0f; 
        [SerializeField] private float _gravity = 20.0f;
        [SerializeField] private float _lookSpeed = 2.0f;
        [SerializeField] private float _lookHorizontlLimit = 45.0f;
        [SerializeField] private Camera _playerCamera;
        private CharacterController _characterController;
        private Vector3 _moveDirection = Vector3.zero;
        private float _rotationHorizontl = 0;
        //private bool _canMove = true;
        private IPlayerCharacterMovements _inputActions;

        public override void Hit()
        {
            throw new System.NotImplementedException();
        }

        private void Start()
        {
            _inputActions = FindAnyObjectByType<InputControlCharacter>();
            _characterController = GetComponent<CharacterController>();
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        private void Update()
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 right = transform.TransformDirection(Vector3.right);
            Vector2 mouseDirection = _inputActions.MoveDirection();
            Vector3 moveDirection = _inputActions.MoveDirection();
            bool isSprint = _inputActions.SprintEnter();
            RecalculateAxes(out forward, out right);
            float movementDirectionHorizontal = Run(forward, right, moveDirection, isSprint);
            Jump(movementDirectionHorizontal);
            //ApplyGravity();
            Move();
            Rotation(mouseDirection);
        }

        private void Rotation(Vector2 mouseDirection)
        {
            //if (_canMove)
            //{
            mouseDirection = _inputActions.MouseDirection();
            _rotationHorizontl += -mouseDirection.y * _lookSpeed;
            _rotationHorizontl = Mathf.Clamp(_rotationHorizontl, -_lookHorizontlLimit, _lookHorizontlLimit);
            _playerCamera.transform.localRotation = Quaternion.Euler(_rotationHorizontl, 0, 0);
            transform.rotation *= Quaternion.Euler(0, mouseDirection.x * _lookSpeed, 0);
            //}
        }

        private void Move()
        {
            _characterController.Move(_moveDirection * Time.deltaTime);
        }

        private void ApplyGravity()
        {
            if (!_characterController.isGrounded)
            {
                _moveDirection.y -= _gravity * Time.deltaTime;
            }
        }

        private void Jump(float movementDirectionY)
        {
            /*  if (Input.GetButton("Jump") && canMove && _characterController.isGrounded)
              {
                  _moveDirection.y = _jumpSpeed;
              }
              else
              {
                  _moveDirection.y = movementDirectionY;
              }*/
        }

        private float Run(Vector3 forward, Vector3 right, Vector3 moveDirection,bool isSprint)
        {
            bool isRunning = isSprint;
            //   float speedHorizontal = _canMove ? (isRunning ? _runningSpeed : _walkingSpeed) * moveDirection.z : 0;
            //float speedVertical = _canMove ? (isRunning ? _runningSpeed : _walkingSpeed) * moveDirection.x : 0;
            float speedHorizontal = (isRunning ? _runningSpeed : _walkingSpeed) * moveDirection.z;
            float speedVertical = (isRunning ? _runningSpeed : _walkingSpeed) * moveDirection.x;
            float movementDirectionY = _moveDirection.y;
            _moveDirection = (forward * speedHorizontal) + (right * speedVertical);
            return movementDirectionY;
        }

        private void RecalculateAxes(out Vector3 forward, out Vector3 right)
        {
            forward = transform.TransformDirection(Vector3.forward);
            right = transform.TransformDirection(Vector3.right);
        }
    }
}
