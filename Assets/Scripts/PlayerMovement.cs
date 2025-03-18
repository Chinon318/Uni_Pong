using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

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

        if (verMovement != 0 )
        {
            Vector2 direccion = new Vector2(0,verMovement);

            rb.MovePosition((Vector2)transform.position + direccion * speed);
        }
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pelota"))
        {
            InicioPelota pelotaRef = collision.gameObject.GetComponent<InicioPelota>();
            pelotaRef.rbPelota.AddForceX(5, ForceMode2D.Impulse);
            Debug.Log("Golpe");
        }
    }*/
}
