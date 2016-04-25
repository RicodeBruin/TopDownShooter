using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {


	NavMeshAgent _navMeshAgent;
	GameObject _playerGameObject;

	void Awake () 
	{
		_navMeshAgent = GetComponent<NavMeshAgent> ();
		_playerGameObject = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update () 
	{
		_navMeshAgent.SetDestination (_playerGameObject.transform.position);
	}


}
