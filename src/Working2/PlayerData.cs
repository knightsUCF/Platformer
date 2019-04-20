using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerData : MonoBehaviour
{


	public static PlayerData dpl = null;



	GameObject player;
	Vector3 pos;





	void Awake()
	{
		dpl = this;
	}




	public Vector3 GetLocation()
	{
		if (player == null)
    	{
    		player = GameObject.FindGameObjectWithTag("hero");
    	}

    	if (player != null)
    	{

	    	pos = player.transform.position;
    	}

		return pos;
	}



	/*
    void Update()
    {
    	if (player == null)
    	{
    		player = GameObject.FindGameObjectWithTag("hero");
    	}


    	if (player != null)
    	{

	    	pos = player.transform.position;
	    	Debug.Log(pos);
    	}

        
    }
    */
}
