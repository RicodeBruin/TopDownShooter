using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody _rigidbody;
	public Vector3 _direction;
	public Rigidbody rb;
	public float speed;

	void Awake () 
	{
		_rigidbody = GetComponent<Rigidbody>();
	}

	void Update () 
	{
		float x = Input.GetAxisRaw ("Horizontal");
		float z = Input.GetAxisRaw ("Vertical");
		_direction = new Vector3 (x, 0f, z);

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Plane plane = new Plane (Vector3.up, Vector3.zero);
		float distance;

		if (plane.Raycast (ray, out distance))
		{
			Vector3 point = ray.GetPoint (distance);
			Vector3 adjustedheightpoint = new Vector3 (point.x, transform.position.y, point.z);
			transform.LookAt (adjustedheightpoint);
		}
	}

	void FixedUpdate()
	{
		Vector3 velocity = _direction.normalized * speed * Time.fixedDeltaTime;
		_rigidbody.MovePosition(_rigidbody.position + velocity);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("PickUps"))
		{
			Destroy(other.gameObject);
		}

	}

}
