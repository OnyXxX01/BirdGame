using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBombs : MonoBehaviour
{
    public GameObject bomb;
    public GameObject coin;
    public Sprite coin0;

    void Start()
    {

        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            //Spawn bombs ===============================
            Instantiate(bomb, new Vector2 (UnityEngine.Random.Range (-2.5f, 2.5f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);

            //Spawn coins ===============================
            Instantiate(coin, new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
    void OnTriggerEnter2D(Collider2D obj)
    {
       

        if (obj.gameObject.tag == "coin")
        {

            this.GetComponent<SpriteRenderer>().sprite = coin0;

        }

    }


}
