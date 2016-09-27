using UnityEngine;
using System.Collections;

public class SpawnBulletAtMouse : MonoBehaviour {

    public GameObject bullet;
    Vector3 mousePos;
    Camera mainCam;

    [HideInInspector]
    public bool canDrop = true;

    void Start()
    {
        mainCam = Camera.main;
    }

	void Update () { 
	    if(Input.GetMouseButtonDown(0) && canDrop) {
            mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            Instantiate(bullet, mousePos, Quaternion.Euler(new Vector3(0, 0, 0)));
            }
        }
}

