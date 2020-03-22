using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBombs : MonoBehaviour
{
    public GameObject bomb;
    public GameObject coin;
    public GameObject coinJele;
    public Sprite coin0;

    void Start()
    {

        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        int i = 1;
        while (!Player.lose)
        {
            
            //Spawn bombs ===============================
            Instantiate(bomb, new Vector2 (UnityEngine.Random.Range (-2.5f, 2.5f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);



            //Spawn coins ===============================
            if (i %10 ==0 )
            {
                Instantiate(coinJele, new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 5.9f), Quaternion.identity);
                yield return new WaitForSeconds(1f);
            }
            else
            {
                Instantiate(coin, new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 5.9f), Quaternion.identity);
                yield return new WaitForSeconds(1f);
            }
            i++;
        }
    }
    void OnTriggerEnter2D(Collider2D obj)
    {
       

        if (obj.gameObject.tag == "coin" | obj.gameObject.tag == "coinJele")
        {

            this.GetComponent<SpriteRenderer>().sprite = coin0;

        }

    }


}
