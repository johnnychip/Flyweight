using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

	[SerializeField]
	private int health;
	[SerializeField]
	private int attack;
	[SerializeField]
	private int defense;
	[SerializeField]
	private Team myTeam;
	[SerializeField]
	private Vector2 gridPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Attack(Unit otherUnit){
		if (otherUnit.MyTeam != myTeam) {
			otherUnit.Damage (attack);
		}
	}

	public void Move(){
	}

	public void Damage(int enemyAttack){
		health -= defense - enemyAttack;
		if (health <= 0)
			gameObject.SetActive (false);
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
