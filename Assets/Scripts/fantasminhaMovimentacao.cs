using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class fantasminhaMovimentacao : MonoBehaviour
{
    public Transform Jogador;
    private NavMeshAgent agent;
    public AudioSource somMorte;



    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = Jogador.position;
    }

    public void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag=="GameController"){
            somMorte.Play();
            SceneManager.LoadScene("GameOv");
        }
    }
}
