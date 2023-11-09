using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int moedasNaFase;

    public AudioSource somMoeda;

    public string nomeDaProxFase;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DescontarMoedas(){
        moedasNaFase -= 1;
        somMoeda.Play();

        if(moedasNaFase <=0){
            SceneManager.LoadScene(nomeDaProxFase);
        }
    }


}
