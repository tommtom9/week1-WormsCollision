using UnityEngine;
using System.Collections;


public class BulletController : MonoBehaviour {

	[SerializeField]private Transform bulletSpriteTransform;    
	[SerializeField]private CircleCollider2D destructionCircle;
	public static GroundController groundController;

	void Start () {
        StartCoroutine(lifetime());
	}

	void OnCollisionEnter2D( Collision2D coll ){

        if (coll.gameObject.tag == "Ground" ){
            groundController.DestroyGround(destructionCircle);
            Destroy(gameObject);
            }
		}

    IEnumerator lifetime(){
        yield return new WaitForSeconds(7f);
        Destroy(gameObject);
    }
}
    
