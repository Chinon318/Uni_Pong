using UnityEngine;

public class InicioPelota : MonoBehaviour
{
    public Rigidbody2D rbPelota;
    [SerializeField] private float fuerzaInicial = 10;
    [SerializeField] private bool inicioJuego;

    public Transform spawn;



    void Awake()
    {
        rbPelota = GetComponent<Rigidbody2D>();
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
            rbPelota.AddForce(Vector2.one * fuerzaInicial, ForceMode2D.Impulse);
            inicioJuego = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        inicioJuego = false;
        rbPelota.linearVelocity = Vector2.zero;
        transform.position = spawn.position;
    }
}
