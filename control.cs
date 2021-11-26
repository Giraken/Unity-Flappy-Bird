using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public float berat, tinggiLoncat;
    public GameObject bird, instruction, pipeCopy, skor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Escape))
        {
            Application.Quit ();
        }
                
        if (Input.GetKeyDown (KeyCode.Space))
        {
            if (Time.timeScale == 1)
            {
                GameObject.Find("suara wing").GetComponent<AudioSource> ().Play ();
                pipeCopy.SetActive(true);
                skor.SetActive(true);
                instruction.SetActive(false);
                bird.GetComponent<Rigidbody2D> ().gravityScale = berat;
                bird.GetComponent<Rigidbody2D> ().velocity = new Vector2 (bird.GetComponent<Rigidbody2D> ().velocity.x, tinggiLoncat);
            }
        }
    }
}
