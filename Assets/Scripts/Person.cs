using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public GameManager gameManager;
    public Vector3 personStartPosition;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        personStartPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.tag == "Room"){
             if(gameObject != gameManager.randomPerson){
                
                gameManager.personText.SetActive(true);
                gameManager.RemoveObjectAndPerson(gameObject);
              
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.tag == "Room"){
            
            gameManager.personText.SetActive(false);           
        }
    }
}
