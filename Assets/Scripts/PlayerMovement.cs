using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    public bool player1;

    public Transform posInicial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Cursor.lockState = CursorLockMode.Locked;

        rb.position = posInicial.position;
    }

    void FixedUpdate()
    {
        MovimientoPersonaje();
    }

    private void MovimientoPersonaje()
    {
        float verMovement = Input.GetAxis("Vertical");
        float mouseY = Input.GetAxis("Mouse Y");

        if (verMovement != 0  && player1)
        {
            Vector2 direccion = new Vector2(0,verMovement);

            rb.MovePosition((Vector2)transform.position + direccion * speed);
        }
        if (mouseY != 0 && !player1)
        {
            Vector2 direccion = new Vector2(0,mouseY);

            rb.MovePosition((Vector2)transform.position + direccion * speed);
        }
    }
}
