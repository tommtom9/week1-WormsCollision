using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ReloadScript : MonoBehaviour {

	public void reload() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
