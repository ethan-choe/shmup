using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public List<Transform> BodyParts = new List<Transform>();
    public float mindistance = 0.25f;

    public int beginsize;
    public float speed = 1;
    public float rotationspeed = 50;
    public float            rollMult = -45;
    public float            pitchMult = 30;


    public GameObject bodyprefab;
    private float dis;
    private Transform curBodyPart;
    private Transform PrevBodyPart;

    // private Hero s;

    void Start()
    {
        for(int i = 0; i < beginsize - 1; i++)
        {
            AddBodyPart();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        //Test
        if(Input.GetKeyDown(KeyCode.Q))
        {
            AddBodyPart();
        }
    }

    public void Move()
    {
        // Alter speed of towed ships
        float curspeed = speed;
        if(Input.GetKey(KeyCode.W))     // Change this to correspond to ship
        {
            curspeed *= 2;
        }

        // Movement
        // Pull in information from the Input class
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        // Change transform.position based on the axes
        Vector3 pos = transform.position;
        pos.x += xAxis * speed * Time.deltaTime;
        pos.y += yAxis * speed * Time.deltaTime;
        transform.position = pos;

        // Rotate the ship to make it feel more dynamic
        transform.rotation = Quaternion.Euler(yAxis*pitchMult,xAxis*rollMult,0);

        if(Input.GetAxis("Horizontal") != 0)
        {
            BodyParts[0].Rotate(Vector3.up * rotationspeed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }

        // BodyPart separation.
        for (int i = 1; i < BodyParts.Count; i++)
        {
            curBodyPart = BodyParts[i];
            PrevBodyPart = BodyParts[i-1];

            dis = Vector3.Distance(PrevBodyPart.position, curBodyPart.position);
            Vector3 newpos = PrevBodyPart.position;
            newpos.z = BodyParts[0].position.z;

            float T = Time.deltaTime * dis / mindistance * curspeed;

            if( T > 0.5f)
            {
                T = 0.5f;
            }
            curBodyPart.position = Vector3.Slerp(curBodyPart.position, newpos, T);
            curBodyPart.rotation = Quaternion.Slerp(curBodyPart.rotation, PrevBodyPart.rotation, T);
        }

    }
    public void AddBodyPart()
    {
        Transform newpart = (Instantiate(bodyprefab, BodyParts[BodyParts.Count -1].position, BodyParts[BodyParts.Count -1].rotation) as GameObject).transform;

        newpart.SetParent(transform);
        BodyParts.Add(newpart);
    }

    void OnCollisionEnter( Collision coll)
    {
        GameObject otherGO = coll.gameObject;
        if (otherGO.tag == "Enemy")
        {
            Destroy( otherGO );         // Destroy the Projectile
            Destroy( gameObject );      // Destroy this Enemy GameObject
        } else {
            print( "Enemy hit by non-Enemy: " + otherGO.name );
        }
    }

}
