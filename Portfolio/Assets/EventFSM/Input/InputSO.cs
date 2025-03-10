using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace EFSM
{
    [CreateAssetMenu(menuName = "SO/Input")]
    public class InputSO : ScriptableObject, InputActions.IPlayerActions
    {
        private InputActions inputAction;

        public Action onAttack;
        public Action<Vector2> onMove;

        private void OnEnable()
        {
            if (inputAction == null)
            {
                inputAction = new InputActions();
                inputAction.Player.SetCallbacks(this);
            }
            inputAction.Player.Enable();
        }

        private void OnDisable()
        {
            if (inputAction != null)
                inputAction.Player.Disable();
        }

        public void OnAttack(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                onAttack.Invoke();
            }
        }
        public void OnMove(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                onMove?.Invoke(context.ReadValue<Vector2>());
            }
        }
        #region unused
        public void OnCrouch(InputAction.CallbackContext context)
        {
        }
        public void OnInteract(InputAction.CallbackContext context)
        {
        }
        public void OnJump(InputAction.CallbackContext context)
        {
        }
        public void OnLook(InputAction.CallbackContext context)
        {
        }
        public void OnNext(InputAction.CallbackContext context)
        {
        }
        public void OnPrevious(InputAction.CallbackContext context)
        {
        }
        public void OnSprint(InputAction.CallbackContext context)
        {
        }
        #endregion
    }
}
