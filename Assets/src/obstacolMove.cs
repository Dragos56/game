using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class obstacolMove : MonoBehaviour
{
    public float speed = 5f;
    public float limita = -25f;
    public Transform pozitie;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * speed * Time.deltaTime;   
        if (transform.position.x < limita)
        {
            Destroy(gameObject);
        }  
    }
}
