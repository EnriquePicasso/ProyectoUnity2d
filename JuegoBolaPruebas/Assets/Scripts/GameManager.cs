using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public AudioSource audioSource;

    public TMP_Text textoNumeroPuntos;
    public TMP_Text textoTotalObjetos;
    private int puntos;
    private int totalPuntos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        totalPuntos = transform.childCount;
        puntos = 0;
        textoNumeroPuntos.text = "0";
        textoTotalObjetos.text = totalPuntos.ToString();
    }

    private void Update()
    {
        if (puntos >= totalPuntos)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }

    public void SumaPuntos() {
        audioSource.Play();
        puntos++;
        textoNumeroPuntos.text = puntos.ToString();
    }
}
