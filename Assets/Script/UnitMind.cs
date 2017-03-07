using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMind : MonoBehaviour {

	[SerializeField]
	private Grid myGrid;


	public void UpdateUnit(Unit unit)
	{
		int move;
		if (unit.MyTeam == Team.A) {
			move = 1;
		} else {
			move = -1;
		}
		if (myGrid.tiles [unit.x + move, unit.y].UnitOn == null) {
			unit.Move ((unit.x + move), unit.y);
		} else {
			unit.Attack (myGrid.tiles [(unit.x + move), unit.y].UnitOn);
		}

	}

}
