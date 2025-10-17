using UnityEngine;
using UnityEngine.SceneManagement;

public class KillScript : MonoBehaviour
{

    public string playerTag = "Player";
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            ResetScene();
        }
    }

    public void ResetScene()
    {
        Scene cs = SceneManager.GetActiveScene();

        SceneManager.LoadScene(cs.name, LoadSceneMode.Single);
    }
}
