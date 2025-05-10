using UnityEngine;
using TMPro;

public class LogicaPuntaje : MonoBehaviour
{
    public static int puntaje = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntaje = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = puntaje.ToString();
    }
}
