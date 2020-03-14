using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static bool lose = false;
    public Sprite deathbirdbomb;
 
    public GameObject restart;
    public GameObject boom1;
    public Text pointsText;

    public float points = 0;
    public bool isStarted = false;

    void Awake()
    {
        lose = false;
        isStarted = true;
    }
    void Update()
    {
        pointsText.text = "" + points;
        
    }

    void FixedUpdate()
    {
       
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Bomb")
        {
            lose = true;
            restart.SetActive (true);
            boom1.SetActive(true);
            this.GetComponent<SpriteRenderer>().sprite = deathbirdbomb;
          
        }

        if(obj.gameObject.tag == "coin")
        {
            if (isStarted)
            {
                points++;
                
            }

           
        }
         
    }

}
