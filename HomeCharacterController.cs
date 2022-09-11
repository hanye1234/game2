using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeCharacterController : MonoBehaviour
{
    Vector3 WalkingDirection=new Vector3(0,0,0);
    bool isWalking = false;
    float WalkingTime=0;
    public Transform[] Borders;
    SpriteRenderer sprite;

    public GameObject nekotyan;
    // Start is called before the first frame update
    void Start()
    {
        transform.position=new Vector3(-1.5f,-5.0f,-1);
        sprite=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(WalkingDirection.x<0)
        {
            sprite.flipX=true;
        }
        else if(WalkingDirection.x>0)
        {
            sprite.flipX=false;
        }

        WalkingTime+=Time.deltaTime;
        
        if(isWalking==false && WalkingTime<3.0f)
        {
            isWalking=true;
            WalkingDirection=new Vector3(Random.Range(-3.0f,4.0f),Random.Range(-3.0f,4.0f),0).normalized;
        }

        if(isWalking)
        {
            if(transform.position.x<Borders[0].position.x || transform.position.y>Borders[0].position.y || transform.position.y <Borders[1].position.y || transform.position.x>Borders[1].position.x)
            {
                BackToCenter();
            }
        }


        if(isWalking && WalkingTime>=3.0f)
        {
            isWalking=false;
            WalkingDirection=new Vector3(0,0,0);
        }

        if(WalkingTime>=5.0f)
        {
            WalkingTime=0;
        }

        

        transform.Translate(WalkingDirection*Time.deltaTime);
    }

    void BackToCenter()
    {
        WalkingDirection=new Vector3(-(transform.position.x+1.5f),-(transform.position.y+5.0f),0).normalized;
        WalkingDirection=WalkingDirection*0.5f;
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("neko"))
        {
            nekotyan.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("neko"))
        {
            nekotyan.SetActive(false);
        }    
    }

}
