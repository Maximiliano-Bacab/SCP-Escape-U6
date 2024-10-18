using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowAI : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform player;

    private Rigidbody2D rb2d;
    private Vector2 moveDirection;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Calcula la dirección hacia la que el monstruo debe moverse.
        moveDirection = (player.position - transform.position).normalized;

        // Mueve el monstruo utilizando el Rigidbody2D y asegúrate de que choque con objetos 2D.
        rb2d.MovePosition(rb2d.position + moveDirection * speed * Time.fixedDeltaTime);
    }
}
