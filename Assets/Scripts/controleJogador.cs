using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controleJogador : MonoBehaviour
{

    public float velocidadeJogador;
    public Rigidbody rigidBody;

    private float movimentoX;
    private float movimentoZ;

    void Start()
    {
        
    }

    void Update()
    {
        MovimentarBolinha();
    }


    private void MovimentarBolinha()
    {
        movimentoX = Input.GetAxis("Horizontal") * velocidadeJogador;
        movimentoZ = Input.GetAxis("Vertical") * velocidadeJogador;

        rigidBody.AddForce(movimentoX, 0f, movimentoZ);
    }
}
