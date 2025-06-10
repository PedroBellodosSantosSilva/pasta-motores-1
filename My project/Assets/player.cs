using UnityEngine;

public class player : MonoBehaviour
{

    private SpriteRenderer AllaySprite;
    private Rigidbody2D Rigid;
    
    public float velocidade = 10;
    public float forcaDePulo = 5;
   
    void Start()
    {
        AllaySprite = GetComponent<SpriteRenderer>();
        Rigid = GetComponent<Rigidbody2D>();
    }

 
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3( velocidade *Time.deltaTime , 0, 0);
            AllaySprite.flipX = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);
            AllaySprite.flipX = false;
        }


        if (Input.GetKey(KeyCode.J))
        {
            Rigid.AddForce(new Vector2(0, forcaDePulo), ForceMode2D.Impulse);
        }
        
    }
}
