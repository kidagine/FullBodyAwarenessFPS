using UnityEngine;

public class CameraFollower : MonoBehaviour
{

	public float cameraMoveSpeed = 120.0f;
	public GameObject cameraFollowObject;
	public float clampAngle = 80.0f;
	public float inputSensitivity = 150.0f;
	public float mouseX;
	public float mouseY;
	public float finalInputX;
	public float finalInputZ;
	private float rotationY = 0.0f;
	private float rotationX = 0.0f;

	void Start()
	{
		Vector3 rotation = transform.localRotation.eulerAngles;
		rotationY = rotation.y;
		rotationX = rotation.x;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void Update()
	{
		mouseX = Input.GetAxis("Mouse X");
		mouseY = Input.GetAxis("Mouse Y");
		finalInputX = 0 + mouseX;
		finalInputZ = 0 + mouseY;

		rotationY += finalInputX * inputSensitivity * Time.deltaTime;
		rotationX += finalInputZ * inputSensitivity * Time.deltaTime;

		rotationX = Mathf.Clamp(rotationX, -clampAngle, clampAngle);

		Quaternion localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);
		transform.rotation = localRotation;
	}

	void LateUpdate()
	{
		CameraUpdater();
	}

	private void CameraUpdater()
	{
		Transform target = cameraFollowObject.transform;
		float step = cameraMoveSpeed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}
}