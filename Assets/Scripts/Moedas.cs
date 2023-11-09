using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moedas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<GameManager>().moedasNaFase += 1;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("GameController")){
            FindObjectOfType<GameManager>().DescontarMoedas();
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
