using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 10f;
	public float rotationSpeed = 10f;

	public Joystick joystick;

	private float rotation;

	private Rigidbody rb;
	

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update ()
	{
			
		if (joystick.Horizontal >= 0.2f || joystick.Horizontal <= -0.2f)
        {
			rotation = joystick.Horizontal;
		}
		else
        {
			rotation = Input.GetAxisRaw("Horizontal");
		}
  
		
	}

	void FixedUpdate ()
	{
		rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
		Vector3 yRotation = Vector3.up * rotation * rotationSpeed * Time.fixedDeltaTime;
		Quaternion deltaRotation = Quaternion.Euler(yRotation);
		Quaternion targetRotation = rb.rotation * deltaRotation;
		rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 50f * Time.deltaTime));
		//transform.Rotate(0f, rotation * rotationSpeed * Time.fixedDeltaTime, 0f, Space.Self);
	}

}
