using UnityEngine;
using System.Collections;

public class RotatingTombstone : MonoBehaviour
{
    public float speed = 40f;

    void Update()
    {
        this.transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
