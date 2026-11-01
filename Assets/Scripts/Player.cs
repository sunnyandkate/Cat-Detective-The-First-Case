using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    public float moveSpeed;
    public Vector2 movePosition;
    public float speed;
    float xInput;
    float yInput;

    public GameObject playerObject;
    public GameObject playerPerson;
    public GameObject choosenObject;
    public GameObject choosenRoom;
    public GameObject choosenPerson;
    public GameManager gameManager;

    public Vector3 choosenPersonStartPosition;
    public Vector3 choosenObjectStartPosition;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
         

       
    }
    private void FixedUpdate(){
        //player movement
       if(gameManager.gameStarted){
            xInput =Input.GetAxis("Horizontal");
            yInput = Input.GetAxis("Vertical");
            transform.Translate(xInput * moveSpeed * Time.deltaTime, yInput * moveSpeed * Time.deltaTime, 0f);
            MovePlayer();
       }
       
       

    }
    private void MovePlayer(){
        animator.SetFloat("MoveX", xInput);
        animator.SetFloat("MoveY", yInput);
        
        if(xInput != 0 || yInput != 0){
             animator.SetBool("Walk", true);
        }else if(xInput == 0 && yInput == 0){
            animator.SetBool("Walk", false);
        } 
         if(Input.GetMouseButton(0)){
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            movePosition = mousePos;
        
            transform.position = Vector2.MoveTowards(transform.position, movePosition, speed * Time.deltaTime);

           
        }
    
       
    }
   

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Room"){
            
            //save the room the player entered in choosenroom
            choosenRoom = other.gameObject;
              //if the player enters a room, check if the object, person and room are right
            if(choosenObject == gameManager.randomObject && choosenRoom == gameManager.randomRoom && choosenPerson == gameManager.randomPerson){
               
                gameManager.Win();
            }
          /*   if(choosenObject != gameManager.randomObject){
                Debug.Log("wrong object");
               
                Destroy(choosenObject);
            } */
           /*  if(choosenPerson != gameManager.randomPerson){
                Debug.Log("wrong person");
                Destroy(choosenPerson);
            } */
          /*   if(choosenRoom != gameManager.randomRoom){
                Debug.Log("wrong room");
            } */
          
           
        }
        if(other.gameObject.tag == "Person"){
            choosenPerson = other.gameObject;
            choosenPersonStartPosition = choosenPerson.transform.position;
             if(playerPerson.transform.childCount <= 0){
                
                choosenPerson.transform.parent = playerPerson.gameObject.transform;
               
            }
            //set the choosenperson to the current child of players playerPerson
             choosenPerson = playerPerson.transform.GetChild(0).gameObject;
        }
        if(other.gameObject.tag == "Objects"){
            //save the choosen object
            choosenObject = other.gameObject;
            //get the start position of the object
            choosenObjectStartPosition = choosenObject.transform.position;
                        
            //if the players child child is empty, set the object as a child
            if(playerObject.transform.childCount <= 0){
               
                choosenObject.transform.parent = playerObject.gameObject.transform;
            }
            choosenObject = playerObject.transform.GetChild(0).gameObject;
          
        }
    }
}
