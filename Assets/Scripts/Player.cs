using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static bool lose = false;
    public Sprite deathbirdbomb;
 
    public GameObject restart;
    public GameObject boom1;
    public GameObject bac;
    public Text pointsText;

    public GameObject mainCam;
    public AudioSource mainCamSource;
  
    public AudioSource audioS;
    public AudioClip audioclip;
    public AudioClip audioboom;

    public float points = 0;
    public bool isStarted = false;

    private void Start()
    {
        audioS = GetComponent<AudioSource>();
       
     
    }
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
            restart.SetActive(true);
            boom1.SetActive(true);
            Destroy(obj.gameObject);
            this.GetComponent<SpriteRenderer>().sprite = deathbirdbomb;
            audioS.PlayOneShot(audioboom);
            mainCam = GameObject.Find("Main Camera");
            mainCamSource = mainCam.GetComponent<AudioSource>();
            mainCamSource.Stop();

            Destroy(GameObject.FindWithTag("Bomb"));
            Destroy(GameObject.FindWithTag("coin"));

           
        }

        if (obj.gameObject.tag == "coin" | obj.gameObject.tag == "coinJele")
        {
            if (isStarted)
            {
                points++;
                Destroy(obj.gameObject);
                audioS.PlayOneShot(audioclip);
               
            }

           
        }
         
    }

}
