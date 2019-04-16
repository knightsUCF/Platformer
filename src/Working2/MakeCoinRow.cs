using System.Collections;
using System.Collections.Generic;
using UnityEngine;







public class MakeCoinRow : MonoBehaviour
{
    

	public GameObject CoinModel;
	public float ModelWidth = 4;
	public int RowLength = 100;
	public float Interval = 10;
	public float yHeight = 5f;
	public float zDistance = 40f;

	


	void GenerateRow()
	{
		for (int i = 1; i <= RowLength; i++)
		{
			Instantiate(CoinModel, new Vector3(i * ModelWidth + Interval, yHeight, zDistance), Quaternion.identity, this.transform);
		}
	}



	void Start()
	{
		GenerateRow(); 
	}



}



/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Procedural : MonoBehaviour
{


	public GameObject platform;
	public GameObject platformStart;
	public float width = 80.0f;
	public float offset = 4.0f;
	public int maxIterations = 4;


	
	void GenerateTerrain()
	{
		// a generate a line of terrain evenly spaced - width is 40


		// make the first one, a little bigger to have an easy start of the level

		Instantiate(platformStart, new Vector3(15, 0, 0), Quaternion.identity, this.transform);


		// then make a series

		for (int i = 1; i <= maxIterations; i++)
		{
			Instantiate(platform, new Vector3(i * width + offset, 0, 0), Quaternion.identity, this.transform);
		}
	}



	void Start()
	{
		GenerateTerrain();
	}




}

*/
