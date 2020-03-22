using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falldownCoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    [SerializeField]
    private float fallSpeed = 5;

    void Update()
    {
        if (transform.position.y < -6f)
            Destroy(gameObject);

        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }
}
