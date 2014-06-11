using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour
{
    public Transform bullet;

    void Update()
    {
        if (Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftAlt))
        {
            Transform shot = Instantiate(bullet, transform.position, Quaternion.identity) as Transform;
            
        }
            
    }
}