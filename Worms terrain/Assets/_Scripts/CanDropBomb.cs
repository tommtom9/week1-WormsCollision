using UnityEngine;
using System.Collections;

public class CanDropBomb : MonoBehaviour {

    SpawnBulletAtMouse spawnBulletAtMouse;

    void Start() {
        spawnBulletAtMouse = Camera.main.GetComponent<SpawnBulletAtMouse>();
    }

    public void PointerEnter() {
        spawnBulletAtMouse.canDrop = false;
    }

    public void PointerExit() {
        spawnBulletAtMouse.canDrop = true;
    }

    public void OnMouseEnter() {
        Debug.Log("test");
        spawnBulletAtMouse.canDrop = false;
    }

    public void OnMouseExit() {
        spawnBulletAtMouse.canDrop = true;
    }
}
