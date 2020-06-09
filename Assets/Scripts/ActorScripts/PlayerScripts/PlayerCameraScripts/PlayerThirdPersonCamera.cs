using UnityEngine;

public class PlayerThirdPersonCamera : MonoBehaviour, IPlayerCamera
{
	[SerializeField] private Transform _player;
	[SerializeField] private PlayerMovement _playerMovement;
	public float minimumDistance = 1.0f;
	public float maximumDistance = 4.0f;
	public Transform pivot;
	public float smooth = 10.0f;
	private Vector3 dollyDirection;
	public Vector3 dollyDirectionAdjusted;
	public float distance;
	public LayerMask playerIgnore;
	public float cameraMoveSpeed = 5.0f;
	public GameObject cameraFollowObject;
	public float clampAngle = 80.0f;
	public float inputSensitivity = 22.0f;
	public float mouseX;
	public float mouseY;
	public float finalInputX;
	public float finalInputZ;
	private float rotationY = 0.0f;
	private float rotationX = 0.0f;
	private Vector2 _cameraInput;

	void Awake()
	{
		dollyDirection = transform.localPosition.normalized;
		distance = transform.localPosition.magnitude;
	}
	void Start()
	{
		Vector3 rotation = pivot.localRotation.eulerAngles;
		rotationY = rotation.y;
		rotationX = rotation.x;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	public void SetCameraInput(Vector2 cameraInput)
	{
		_cameraInput = cameraInput;
	}

	void Update()
	{
		mouseX = _cameraInput.x / 4;
		mouseY = -_cameraInput.y / 4;
		finalInputX = 0 + mouseX;
		finalInputZ = 0 + mouseY;

		rotationY += finalInputX * inputSensitivity * Time.deltaTime;
		rotationX += finalInputZ * inputSensitivity * Time.deltaTime;

		rotationX = Mathf.Clamp(rotationX, -clampAngle, clampAngle);

		Quaternion localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);
		pivot.rotation = localRotation;

		Vector3 desiredCameraPosition = transform.parent.TransformPoint(dollyDirection * maximumDistance);
		RaycastHit hit;

		if (Physics.Linecast(transform.parent.position, desiredCameraPosition, out hit, ~playerIgnore))
		{
			distance = Mathf.Clamp((hit.distance * 0.9f), minimumDistance, maximumDistance);
		}
		else
		{
			distance = maximumDistance;
		}
		transform.localPosition = Vector3.Lerp(transform.localPosition, dollyDirection * distance, Time.deltaTime * smooth);

		var lookPos = _player.position - transform.position;
		lookPos.y = 0;
		var rotation = Quaternion.LookRotation(lookPos);
		_player.transform.localRotation = Quaternion.Slerp(_player.transform.localRotation, rotation, Time.deltaTime * _playerMovement.Move.magnitude * 30.0f);

	}

	void LateUpdate()
	{
		CameraUpdater();
	}
	private void CameraUpdater()
	{
		Transform target = cameraFollowObject.transform;
		float step = cameraMoveSpeed * Time.deltaTime;
		pivot.position = Vector3.MoveTowards(pivot.position, target.position, step);
	}

}
