﻿
using UnityEngine;

public class FallDown : MonoBehaviour
{

    [SerializeField]
    private float fallSpeed = 7;

    void Update()
    {
        if (transform.position.y < -6f)
            Destroy(gameObject);

        transform.position -= new Vector3 (0, fallSpeed * Time.deltaTime, 0);
    }
}
