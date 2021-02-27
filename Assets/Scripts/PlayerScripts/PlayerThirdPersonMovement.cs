using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerCamera))]
public class PlayerThirdPersonMovement : MonoBehaviour
{
    private Animator _animator;
    private CharacterController _characterController;
	private PlayerCamera _playerCamera;


    void Awake()
    {
        _animator = GetComponent<Animator>();
        _characterController = GetComponent<CharacterController>();
		_playerCamera = GetComponent<PlayerCamera>();
    }

    public void Movement(float movementSpeed, Vector2 movementInput)
	{
		float speed = new Vector2(movementInput.x, movementInput.y).sqrMagnitude;
		if (speed > 0.0f)
		{
			_playerCamera.GetLookDirection(out Vector3 forward, out Vector3 right);
			Vector3 lookDirection = forward * movementInput.y + right * movementInput.x;
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDirection), 0.1f);
			_characterController.Move(lookDirection * movementSpeed * Time.deltaTime);

			_animator.SetFloat("VelocityY", speed, 0.1f, Time.deltaTime);
		}
		else
		{
			_animator.SetFloat("VelocityY", 0.0f, 0.1f, Time.deltaTime);
		}
	}
}
