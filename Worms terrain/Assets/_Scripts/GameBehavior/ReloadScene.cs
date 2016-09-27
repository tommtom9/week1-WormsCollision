using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ReloadScene : MonoBehaviour {

	public void reload() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
