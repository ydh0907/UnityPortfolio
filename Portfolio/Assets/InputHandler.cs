using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "SO/Input")]
public class InputHandler : ScriptableObject, InputActions.IPlayerActions
{
    private InputActions inputAction;

    private void OnEnable()
    {
        if (inputAction == null)
        {
            inputAction = new InputActions();
            inputAction.Player.SetCallbacks(this);
        }
        inputAction.Player.Enable();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
    }
    public void OnMove(InputAction.CallbackContext context)
    {
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
