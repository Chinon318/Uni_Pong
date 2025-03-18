using UnityEngine;

public class LogicaEnemigo : MonoBehaviour
{
    public Transform pelota;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, pelota.position.y);
    }
}
