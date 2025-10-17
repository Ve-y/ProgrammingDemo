using System.Collections;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 2f;
    private Coroutine destroyCoroutine;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            destroyCoroutine = StartCoroutine(DestroyAfterDelay());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (destroyCoroutine!=null)
            {
                StopCoroutine(destroyCoroutine);
                destroyCoroutine = null;
            }
        }
    }

    private IEnumerator DestroyAfterDelay()
    {
        yield return new WaitForSeconds(destroyDelay);
        Destroy(gameObject);
    }
}
