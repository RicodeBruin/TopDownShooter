using UnityEngine;
using System.Collections;

public class PlayerShootingDouble : MonoBehaviour {



		public Projectile projectile;
		public Transform muzzle;
		public float bulletSpeed;
		public float FireRate;

		private float nextFireTime;

		void Start ()
		{
			Shoot ();
		}

		void Update () 
		{
			if (Input.GetMouseButton (1) && Time.time >= nextFireTime) 
			{
				Shoot();
			}
		}

		private void Shoot()
		{
			Projectile newProjectile = Instantiate (projectile, muzzle.position, muzzle.rotation) as Projectile;
			newProjectile.SetSpeed (bulletSpeed);
			nextFireTime = Time.time + FireRate;
		}
	}