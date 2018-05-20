using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {

	[SerializeField]
    private float speed;

	private Animator animator;

	protected Vector2 direction;

	// Use this for initialization
	protected virtual void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		Move();
	}

	public void Move()
    {
		Vector2 results = direction * speed * Time.deltaTime;
		transform.Translate(results);
		AnimateMovement(direction);
    }

	public void AnimateMovement(Vector2 direction)
	{
		Debug.Log(direction.x);
		animator.SetFloat("x", direction.x);
	}
}
