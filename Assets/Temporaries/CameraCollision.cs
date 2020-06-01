using UnityEngine;

public class CameraCollision : MonoBehaviour
{

	public float minimumDistance = 1.0f;
	public float maximumDistance = 4.0f;
	public float smooth = 10.0f;
	private Vector3 dollyDirection;
	public Vector3 dollyDirectionAdjusted;
	public float distance;

	void Awake()
	{
		dollyDirection = transform.localPosition.normalized;
		distance = transform.localPosition.magnitude;
	}

	void Update()
	{
		Vector3 desiredCameraPosition = transform.parent.TransformPoint(dollyDirection * maximumDistance);
		RaycastHit hit;

		if (Physics.Linecast(transform.parent.position, desiredCameraPosition, out hit))
		{
			distance = Mathf.Clamp((hit.distance * 0.9f), minimumDistance, maximumDistance);
		}
		else
		{
			distance = maximumDistance;
		}
		transform.localPosition = Vector3.Lerp(transform.localPosition, dollyDirection * distance, Time.deltaTime * smooth);
	}

}
