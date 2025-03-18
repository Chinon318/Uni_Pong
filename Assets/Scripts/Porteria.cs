using TMPro;
using UnityEngine;

public class Porteria : MonoBehaviour
{
    public int puntos;
    public int puntosEnemigo;

    public bool porteriaAliada;

    public TMP_Text txt_Puntaje;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pelota") && porteriaAliada)
        {
            Debug.Log("GolEnemigo");
            puntosEnemigo++;
            txt_Puntaje.text = puntosEnemigo.ToString();

        }
        else if(collision.CompareTag("Pelota") && !porteriaAliada)
        {
            Debug.Log("GolAliado");
            
            puntos++;
            txt_Puntaje.text = puntos.ToString();
        }
    }
}
