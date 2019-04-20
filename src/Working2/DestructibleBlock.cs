using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// detect damage and destroy


	// to start out, just detect player collision (check is trigger)



	/*
	todo

	- check where Hurt() is being called - none at all, or in another script (not character behaviour)



	*/






public class DestructibleBlock : MonoBehaviour
{

	public GameObject Block;

	public Transform BlockFragment1;
	public Transform BlockFragment2;


	// not sure where tf is coming from, the last trail is passed into Die(tf), which is at EnemyBehaviour


	public GameObject tf;



	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Entered collider");

		/*

		if (collision.gameObject.tag == "WHATEVER")
		{

		}

		https://answers.unity.com/questions/1382055/how-do-you-trigger-a-specific-collider-using-ontri.html

		*/

		SelfDestructBig(transform); // select is trigger // add tf
		
		// Destroy(Block);
	}



	// modeled after the Blood method

   
	void Fragment(Transform tf, Transform fragment)
	{
		GameObject fragmentGO = Instantiate<GameObject>(fragment.gameObject);
		fragmentGO.transform.position = transform.position + Vector3.up * 1.5f;
		fragmentGO.transform.localScale *= Random.Range(0.5f, 1.5f);
		Rigidbody rig = fragmentGO.GetComponent<Rigidbody>(); // is the rigid body automatically created in the above Instantiate()?
		rig.AddExplosionForce(400f, tf.position + Vector3.down * 0.5f, 3f);
		rig.angularVelocity = Vector3.one;
		Destroy(fragmentGO, 10f);
		Collider c = fragmentGO.GetComponent<Collider>(); // is the fragment already destroyed?
		if (c) 
		{ // why? just garbage collection?
			Destroy(c, 5f);
		}
	}



	void SelfDestructBig(Transform tf)
	{

		Fragment(tf, BlockFragment1);
		Fragment(tf, BlockFragment2);



		/*
		int len = Random.Range(28, 40);
		for (int i = 0; i < len; i++)
		{
			Fragment(tf, BlockFragment1);
			if (i < len * 0.6f)
			{
				Fragment(tf, BlockFragment2);
			}
		}

		*/
	}
	
	


	// last thing: where is tf coming form?


	// after this we should simulate the final Die() method of Moenen


	// the only other method then to simulate is the Hurt() method, which we are not sure were is being called






	// so what is the chain of operation here? what calls blood? and how does the Transform fragment get passed in? and why the transform?





}










// so that's the fragment method 




/*

int len = Random.Range(28, 40);
			for (int i = 0; i < len; i++) {
				Blood(tf, BloodCube);
				if (i < len * 0.6f) {
					Blood(tf, RedBloodCube);
				}
			}


private void Blood (Transform tf, Transform blood) {
		GameObject bo = Instantiate<GameObject>(blood.gameObject);
		bo.transform.position = transform.position + Vector3.up * 1.5f;
		bo.transform.localScale *= Random.Range(0.5f, 1.5f);
		Rigidbody rig = bo.GetComponent<Rigidbody>();
		rig.AddExplosionForce(400f, tf.position + Vector3.down * 0.5f, 3f);
		rig.angularVelocity = Vector3.one;
		Destroy(bo, 10f);
		Collider c = bo.GetComponent<Collider>();
		if(c){
			Destroy(c, 5f);
		}
	}



public void Hurt (float damage, Transform tf) {

		transform.localScale = Vector3.one * 2f;

		Vector3 pos = (transform.position - tf.position).normalized * 0.2f;
		transform.Translate(pos.x + Random.Range(-0.1f, 0.1f), 0f, pos.z + Random.Range(-0.1f, 0.1f));
		HP -= damage;
		if (HP <= 0) {
			Die(tf);
		}

		// -xx
		GameObject o = new GameObject("-x");
		o.transform.position = transform.position + Vector3.up * Mathf.Lerp(4f, 2f, HP / MaxHP);
		o.transform.rotation = Camera.main.transform.rotation;
		TextMesh tm = o.AddComponent<TextMesh>();
		tm.text = damage.ToString("00");
		tm.characterSize = 0.3f;
		tm.color = new Color(0.9f, 0.3f, 0.3f, 1f);
		Destroy(o, 1f);

		int len = Random.Range(6, 14);
		
		for (int i = 0; i < len; i++) {
			Blood(tf, BloodCube);
			if (i < len * 0.3f) {
				Blood(tf, RedBloodCube);
			}
		}

		LastHurtTime = Time.time;

		//SFX
		DemoStage.PlaySound((int)Random.Range(2f, 6.99f));

	}



	*/




    




