using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTimeout : MonoBehaviour
{
    public float timeoutDur = 5.0f;
    public Transform spawn;

    Coroutine timeout;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            timeout = StartCoroutine(Timeout());
        }
    }

    IEnumerator Timeout()
    { 
        yield return new WaitForSeconds(timeoutDur);

        transform.position = spawn.position;
    }

    public void ClearTimeout()
    {
        if (timeout != null)
            StopCoroutine(timeout);
    }

}
