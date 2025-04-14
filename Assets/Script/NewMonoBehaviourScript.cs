using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public AudioSource TouchSound;
    public float Keyinput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TouchSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*6, ForceMode.VelocityChange);
        }

        Keyinput = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().linearVelocity = new Vector3(Keyinput, GetComponent<Rigidbody>().linearVelocity.y, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Candy"))
            TouchSound.Play();
    }
} 