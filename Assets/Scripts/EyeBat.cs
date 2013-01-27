using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class EyeBat : MonoBehaviour, IDamageable {
	public int health; 
	public float speed;
	public float radius;
	public float bob;
	public float bobSpeed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.transform.Translate(new Vector3(Mathf.Cos (Time.realtimeSinceStartup * speed) * radius, Mathf.Sin (Time.realtimeSinceStartup * speed) * radius + Mathf.Sin (Time.realtimeSinceStartup * bobSpeed) * bob, 0));
	}
	
	public bool Damage(int damage){
		rigidbody.AddTorque(new Vector3(0.5f, 0.5f, 0.5f));
		health -= damage;
		if(health <= 0){
			Destroy(this.gameObject);
		}
		return true;
	}
}