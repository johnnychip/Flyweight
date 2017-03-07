using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	private Vector2 TilePosition;
	private Unit unitOn;



	// Use this for initialization
	void Start () {
		
	}

	public void SetTilePosition(int tempX, int tempY)
	{
		TilePosition = new Vector2 (tempX, tempY);
	}

	public Vector2 GetTilePosition()
	{
		return TilePosition;
	}

	public Unit UnitOn {
		get {
			return unitOn;
		}
		set {
			unitOn = value;
		}
	}
}
