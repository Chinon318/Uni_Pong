using UnityEngine;

public class LogicaEnemigo : MonoBehaviour
{
    public Transform pelota;

    public float velocidad = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float target = Mathf.MoveTowards(transform.position.y, pelota.position.y, velocidad);
        transform.position = new Vector2(transform.position.x, target);
    }
}
