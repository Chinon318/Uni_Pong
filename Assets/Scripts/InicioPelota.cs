using UnityEngine;

public class InicioPelota : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float fuerzaInicial = 10;
    [SerializeField] private bool inicioJuego;

    public Transform spawn;



    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inicioJuego = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !inicioJuego)
        {
            rb.AddForce(Vector2.one * fuerzaInicial, ForceMode2D.Impulse);
            inicioJuego = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        inicioJuego = false;
        rb.linearVelocity = Vector2.zero;
        transform.position = spawn.position;
    }
}
