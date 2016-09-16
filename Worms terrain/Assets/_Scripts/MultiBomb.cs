using UnityEngine;
using System.Collections;

public class MultiBomb : MonoBehaviour {

    [SerializeField]
    GameObject Smallbomb;
    [SerializeField]
    int bombCount = 3;

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "Ground")
        {
            for (int i = 0; i < bombCount; i++)
            {
                Instantiate(Smallbomb, gameObject.transform.position, Quaternion.Euler(0,0,Random.Range(0,360)));
            }

            Destroy(GetComponent<MultiBomb>());
        }
    }
}
