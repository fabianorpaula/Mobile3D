using UnityEngine;
using System.Collections.Generic;

public class GeradorInimigo : MonoBehaviour
{
    public List<GameObject> Inimigos;
    public float meuTempo;
    public float distancia = 30;

    void Update()
    {
        meuTempo += Time.deltaTime;
        
        if(meuTempo > 1f)
        {
            GerarInimigo();
            meuTempo = 0;
        }
        
    }


    void GerarInimigo()
    {
        float posRandomica = Random.Range(-3, 3);
        Vector3 posInimigo = new Vector3(posRandomica,
            1, distancia);
        distancia = distancia + 30;
        int escolheInimigo = Random.Range(0, 3);
        Instantiate(Inimigos[escolheInimigo],
            posInimigo,
            Quaternion.identity);
    }
}
