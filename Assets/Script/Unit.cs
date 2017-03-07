using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

	public int x;
	public int y;

	[SerializeField]
	private int health;
	[SerializeField]
	private int attack;
	[SerializeField]
	private int defense;
	[SerializeField]
	private Team myTeam;
	[SerializeField]
	private UnitMind mind;

	private int movement;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (x, y, -0.75f);

	}

	public void Attack(Unit otherUnit){
		if (otherUnit.MyTeam != myTeam) {
			otherUnit.Damage (attack);
		}
	}

	public void Move(int tempX, int tempY){

		transform.position = new Vector3 (tempX, tempY, -0.75f);
		x = tempX;
		y = tempY;

	}

	public void Damage(int enemyAttack){
		health += defense - enemyAttack;
		if (health <= 0)
			gameObject.SetActive (false);
	}

	public void StayThere(){
		Debug.Log("Im still");
	}

	public void UpdateState (){
	
		mind.UpdateUnit (this);

	}

	private void AssignTeam(){
		switch (myTeam) 
		{
		case Team.A:
			movement = 1;
			break;
		case Team.B:
			movement = -1;
			break;
		default:
			Debug.Log("Team no assigned");
			break;
		}
	}
		

	public Team MyTeam {
		get {
			return myTeam;
		}
	}

	public int Health {
		get {
			return health;
		}
		set {
			health = value;
		}
	}
}
