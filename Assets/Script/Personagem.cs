using UnityEngine;

public class Personagem : MonoBehaviour
{

    private Rigidbody Corpo;
    public bool noChao = false;

    void Start()
    {
        Corpo = GetComponent<Rigidbody>();

    }

    
    void Update()
    {
        Pular();
        Mover();
    }

    void Mover()
    {
        Corpo.linearVelocity = new Vector3(0,
            Corpo.linearVelocity.y,
            10);

    }

    void Pular()
    {
        if (noChao == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Corpo.AddForce(Vector3.up * 350);
                noChao = false;
            }
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Chao")
        {
            noChao = true;
        }
    }




}
