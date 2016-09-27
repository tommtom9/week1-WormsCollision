using UnityEngine;
using System.Collections;

public class SmallBomb : MonoBehaviour {

    Rigidbody2D rb;

    [SerializeField]
    float speed = 10;

	void Start() {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(transform.up * speed, ForceMode2D.Force);
	}
	
    
}
