using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoNave : MonoBehaviour
{

    private Rigidbody2D rbPlayer;

    private float movimentoPlayerX;
    public float movimentoPlayerY;

    private float speed;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        movimentoPlayerX = Input.GetAxis("Horizontal");
        movimentoPlayerY = Input.GetAxis("Vertical");

        transform.Translate(movimentoPlayerX, movimentoPlayerY, movimentoPlayerY);

    }
}
