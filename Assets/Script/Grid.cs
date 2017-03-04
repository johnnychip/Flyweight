using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {


	[SerializeField]
	private int mapSizeX;
	[SerializeField]
	private int mapSizeY;
	[SerializeField]
	private GameObject tilePrefab;


	private Tile[,] tiles;

	void Start()
	{
	
		tiles = new Tile[mapSizeX, mapSizeY]; 

		for (int x = 0; x < mapSizeX; x++) {
		
			for (int y = 0; y < mapSizeY; y++) {
			
				GameObject tempCube = Instantiate (tilePrefab, new Vector3 (x, y, 0f), Quaternion.identity);
				tiles [x, y] = tempCube.GetComponent<Tile> ();
			
			}

		}

	}

}
