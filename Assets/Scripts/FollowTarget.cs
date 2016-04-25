using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour 

{

	public Transform target;
	public float smoothTime;

	private Vector3 _offset;
	private Vector3 _velocity = Vector3.zero;

	void Start()
	{
		_offset = transform.position - target.position;
	}
	void FixedUpdate()
	{
		Vector3 targetPosition = target.position + _offset;
		//this.transform.position = target.position - offset;
		transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, smoothTime);
	}
}

//ray = Camera.main.ScreenPointToRay (Input.mousePosition);