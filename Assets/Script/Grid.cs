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

	[SerializeField]
	private Unit player1;

	[SerializeField]
	private Unit player2;

	public Tile[,] tiles;

	void Awake()
	{
	
		tiles = new Tile[mapSizeX, mapSizeY]; 

		for (int x = 0; x < mapSizeX; x++) 
		{
		
			for (int y = 0; y < mapSizeY; y++) 
			{
			
				GameObject tempCube = Instantiate (tilePrefab, new Vector3 (x, y, 0f), Quaternion.identity);
				tiles [x, y] = tempCube.GetComponent<Tile> ();
			
			}

		}
		InitUnits ();

	}

	void Start(){
	

	
	}

	public void InitUnits ()
	{
		
		tiles [0, (mapSizeY-1)].UnitOn = player1;
		player1.Move (0, mapSizeY-1);

		tiles [(mapSizeX - 1), (mapSizeY - 1)].UnitOn = player2;
		player2.Move ((mapSizeX - 1), (mapSizeY - 1));
	}

}
