using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarColorCubo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        Debug.Log("El color del cubo es: " + this.gameObject.GetComponent<Renderer>().material.color.ToString());
    }
}
