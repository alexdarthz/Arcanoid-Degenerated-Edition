using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementscript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 5;//Скорость движения
    private Vector2 velocity;
    private Vector2 move;

    private void Awake()
    {
        // RigidbodyConstraints2D.FreezePositionX;
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            LeftAndRight(); //Движение влево-вправо
        }
    }
    private void LeftAndRight()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
        //Позиция героя = Передвинуть(с A в Б за C);
    }
}
