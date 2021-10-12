using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarColor : MonoBehaviour
{
    public GameObject ethan;
    // Start is called before the first frame update
    void Start()
    {
        ethan.gameObject.GetComponent<Renderer>().material.color = Color.red;
        Debug.Log("El color es: " + ethan.gameObject.GetComponent<Renderer>().material.color.ToString());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
