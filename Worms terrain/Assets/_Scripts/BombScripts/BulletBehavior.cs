using UnityEngine;
using System.Collections;


public class BulletBehavior : MonoBehaviour {

	[SerializeField]private Transform bulletSpriteTransform;    
	[SerializeField]private CircleCollider2D destructionCircle;
	public static GroundController groundController;

	void Start () {
        Destroy(gameObject, 5f);
    }

	void OnCollisionEnter2D( Collision2D coll ){

        if (coll.gameObject.tag == "Ground" ){
            groundController.DestroyGround(destructionCircle);
            Destroy(gameObject);
            }
		}
}