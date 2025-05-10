using UnityEngine;

public class GeneradorObstaculos : MonoBehaviour
{
    public float tiempoMax = 5;
    private float tiempoInicial = 0;
    public GameObject obstaculo;
    public float altura;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //CrearObstaculo();

        GameObject obstaculoNuevo = Instantiate(obstaculo);
        obstaculoNuevo.transform.position = transform.position + new Vector3(0,0,0);
        Destroy(obstaculoNuevo, 8);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (tiempoInicial > tiempoMax)
        {
            CrearObstaculo();
            tiempoInicial = 0;
        }
        else
        {
            tiempoInicial += Time.deltaTime;
        }*/


        if(tiempoInicial > tiempoMax)
        {
            GameObject obstaculoNuevo = Instantiate(obstaculo);
            obstaculoNuevo.transform.position = transform.position + new Vector3(0, Random.Range(-altura,altura), 0);
            Destroy(obstaculoNuevo, 8);
            tiempoInicial = 0;
        }
        else
        {
            tiempoInicial += Time.deltaTime;
        }
    }

    /*void CrearObstaculo()
    {
        GameObject obstaculoNuevo = Instantiate(obstaculo);
        float alturaAleatoria = Random.Range(-altura, altura);
        obstaculoNuevo.transform.position = transform.position + new Vector3(0, alturaAleatoria, 0);
        // Si lo que quieres destruir es el obstáculo después de 10 segundos:
        Destroy(obstaculoNuevo, 10);
    }*/
}
