using System.Collections;
using UnityEngine;

public class DestroyTheTippyTaps : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DESTROY());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DESTROY()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}
