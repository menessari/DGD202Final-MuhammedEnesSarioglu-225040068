using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInputReader : MonoBehaviour
{
    private GameInput inputActions;
    private PlayerMover mover;

    private void Awake()
    {
        inputActions = new GameInput();
        mover = GetComponent<PlayerMover>();
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
    }

    private void Update()
    {
        Vector2 moveInput = inputActions.Player.Move.ReadValue<Vector2>();
        mover.Move(moveInput);
    }
}
