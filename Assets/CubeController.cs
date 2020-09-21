using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12;
    private float deadLine = -10;
    private GameObject ground;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        ground = GameObject.Find("ground");
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == ground || collision.gameObject.tag == "CubeTag")
        {
            audioSource.Play();
        }
    }

}
