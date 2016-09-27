using UnityEngine;
using System.Collections;

public class ChangeBomb : MonoBehaviour {

    [SerializeField]
    GameObject bomb;

    SpawnBulletAtMouse spawnBulletAtMouse;

    // Use this for initialization
    void Start () {
        spawnBulletAtMouse = Camera.main.GetComponent<SpawnBulletAtMouse>();
	}

    public void OnClick() {
        spawnBulletAtMouse.bullet = bomb;
    }
}
