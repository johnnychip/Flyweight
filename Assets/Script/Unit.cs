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
		health -= defense - enemyAttack;
		if (health <= 0)
			gameObject.SetActive (false);
	}

	public void StayThere(){
		Debug.Log("Im still");
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
