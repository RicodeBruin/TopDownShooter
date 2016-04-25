using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour 
{

	public Projectile projectile;
	public Transform muzzle;
	public float bulletSpeed;
	public float fireRate;
	private float nextFireTime;
	public float Bullets = 3;
	public float AmmoLeft = 10;



	public int interval = 2000; // interval between shots
	public float reloadTime = 2; // reload tim

	private float shotTime; // time control

	void Update(){
		// only shoot when there are bullets and it's time to shoot
		if (Bullets>0 && Time.time>nextFireTime && Input.GetMouseButtonDown(0))
		{
			Shoot();
			Bullets--;
		}
		// only reload when out of bullets and there are ammo clips:
		if (Bullets == 0 || Input.GetKeyDown("r"))
		{
			Invoke ("Reload", reloadTime);
		}
	}

	private void Shoot()
	{

		Projectile newProjectile = Instantiate (projectile, muzzle.position, muzzle.rotation) as Projectile;
		newProjectile.SetSpeed (bulletSpeed);
		nextFireTime = Time.time + fireRate;
	}

	void Reload()
	{
		Bullets = 5; // load the bullets
		AmmoLeft --; // decrement clip count
		Debug.Log("Reload");
	}
}
