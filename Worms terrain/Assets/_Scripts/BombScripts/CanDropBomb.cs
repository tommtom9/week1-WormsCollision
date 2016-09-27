using UnityEngine;
using System.Collections;

public class CanDropBomb : MonoBehaviour {

    [SerializeField]SpawnBulletAtMouse spawnBulletAtMouse;  

    public void PointerEnter() {
        spawnBulletAtMouse.canDrop = false;
    }

    public void PointerExit() {
        spawnBulletAtMouse.canDrop = true;
    }

    public void OnMouseEnter() {
        spawnBulletAtMouse.canDrop = false;
    }

    public void OnMouseExit() {
        spawnBulletAtMouse.canDrop = true;
    }
}
