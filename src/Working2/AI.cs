/*


- have some sort of trigger 

- when we come in radius, then engage the player

- the other possibility is just to mindlessly wander around, but that's not very smart

- plus the player would like to have different behaving AIs


- ad a sphere collider on the player as a trigger

- or ad the sphere collider here, and identify the the collision as the player 

*/




using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class AI : MonoBehaviour

{

	// speed

    public float speed = 0.2f;


    // destination

	public Vector3 destination = new Vector3(5f, 0, 0); // set the destination to the player


	// pursue

	bool pursue = false; 


	// do we really need this? 

	bool enter = true;



	// Player location

	// GameObject Player;

	private GameObject player;
	private Vector3 playerPos;





	void Start()
	{
		// get the player's transform for the destination 

		if (player != null) 
		{
			player = GameObject.FindGameObjectWithTag("hero");
		}

		// player = GameObject.Find("Player");
	}




	void OnTriggerEnter(Collider other)
  	{
  		/*
    	if (other.gameObject.name == "Player")
	    {
	      	Debug.Log("Colliding with player");

	      	// https://answers.unity.com/questions/1382055/how-do-you-trigger-a-specific-collider-using-ontri.html

	      	// also cool feature to trigger based on vector location 

	    }
	    */


	    if (other.gameObject.tag == "hero")
	    {
	    	Debug.Log("collider with big enemy!!!");
	    	pursue = true; 
	    }
    }
   






    void Update()
    {


    	playerPos = PlayerData.dpl.GetLocation();

    	Vector3 pursuitDestination = new Vector3 (playerPos.x, 11.8f, 1.0f);



    	if (player == null)
    	{
    		player = GameObject.FindGameObjectWithTag("hero");

    	}


    	if (pursue && playerPos != null)
    	{

    		transform.position = Vector3.Lerp(transform.position, pursuitDestination, speed * Time.deltaTime);
    	}

    

    }




}
