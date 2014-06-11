using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 1);
    }

    void Update()
    {
        transform.Translate(0, 0, -1);
    }
}