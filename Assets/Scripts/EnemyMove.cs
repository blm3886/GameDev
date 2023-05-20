using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyMove : MonoBehaviour
{
    public float speed;
    public float distance;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newY = startPosition.y + Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
