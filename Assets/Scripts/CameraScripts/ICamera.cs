using UnityEngine;

public interface ICamera
{
	void GetLookDirection(out Vector3 forward, out Vector3 right);
	void Activate();
	void Deactivate();

	Vector2 LookInput { get; set; }
}
