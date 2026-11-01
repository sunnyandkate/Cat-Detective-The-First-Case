using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWalking : MonoBehaviour
{

    Rigidbody2D npcRigidbody;
    Vector3 targetPosition;
    public float speed;

    private GameManager gameManager;
    private Player player;
    private Person person;
    Vector3 playerPosition;
    Vector3 choosenPersonStartPosition;
    // Start is called before the first frame update
    void Start()
    {
        npcRigidbody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<Player>();
        gameManager = FindObjectOfType<GameManager>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = player.transform.position;
      
      
    }
    public void FixedUpdate(){

        if(gameManager.gameStarted){
            NPCMovement();
        }
       
    
    }
    private void NPCMovement(){

       
        targetPosition = playerPosition;

        transform.position = Vector2.MoveTowards(transform.position, targetPosition,speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){

            //if player has a person, grab it and move it back to original position

            if(player.playerPerson.transform.childCount > 0){
               
                player.choosenPerson.transform.parent = null;
                player.choosenPerson.transform.position = player.choosenPersonStartPosition;
            }
            if(player.playerObject.transform.childCount > 0){
               
                player.choosenObject.transform.parent = null;
                player.choosenObject.transform.position = player.choosenObjectStartPosition;
            }else{
               
            }
            
        }
        
    }
}
