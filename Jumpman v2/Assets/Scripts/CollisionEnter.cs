using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnter : MonoBehaviour {
    public GameObject obstacle;
    private NewBehaviourScript character;
	// Use this for initialization
	void Start () {
        character = FindObjectOfType<NewBehaviourScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            character.Death();
        }
    }
}
