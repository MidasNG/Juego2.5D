using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform character;
    private float speed = 10;

    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, character.position.x, speed * Time.fixedDeltaTime), 1, -3);
    }
}
