using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [Header ("Set in Inspector")]
    public float bottomY = -16f;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
        }
    }
}
