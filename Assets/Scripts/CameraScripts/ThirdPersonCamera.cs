using UnityEngine;

[RequireComponent(typeof(Camera))]
public class ThirdPersonCamera : MonoBehaviour, ICamera
{
	[SerializeField] private Transform _targetToFollow;
	[SerializeField] private float _cameraSensitivy = 5.0f;
	[SerializeField] private float _clampAngle = 80.0f;
	private readonly float _cameraMoveSpeed = 100.0f;
	private float rotationY;
	private float rotationX;

	public Vector2 LookInput { get; set; }


	void Update()
	{
		rotationY += LookInput.x * _cameraSensitivy * Time.deltaTime;
		rotationX += LookInput.y * _cameraSensitivy * Time.deltaTime;
		rotationX = Mathf.Clamp(rotationX, -_clampAngle, _clampAngle);

		Quaternion localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);
		transform.parent.rotation = localRotation;
	}

	public void GetLookDirection(out Vector3 forward, out Vector3 right)
	{
		forward = new Vector3(transform.forward.x, 0.0f, transform.forward.z);
		right = new Vector3(transform.right.x, 0.0f, transform.right.z);
		forward.Normalize();
		right.Normalize();
		//return forward * MovementInput.y + right * MovementInput.x;
	}

	void LateUpdate()
	{
		float step = _cameraMoveSpeed * Time.deltaTime;
		transform.parent.position = Vector3.MoveTowards(transform.parent.position, _targetToFollow.position, step);
	}

	public void Activate()
	{
		transform.parent.gameObject.SetActive(true);
	}

	public void Deactivate()
	{
		transform.parent.gameObject.SetActive(false);
	}
}
