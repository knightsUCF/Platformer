using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoenenVoxel;






public class CoinPickup : MonoBehaviour
{


	Tokens tokens;



	public bool enter = true;

	public GameObject coinModel;



	void Start()
	{
		tokens = GameObject.FindObjectOfType<Tokens>();
	}



	private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            Debug.Log("entered");
            coinModel.SetActive(false);
            tokens.coins += 1;
            DemoStage.AddKillNum();
            Debug.Log(tokens.coins);
            Destroy(this);
            
        }
    }
    



}
