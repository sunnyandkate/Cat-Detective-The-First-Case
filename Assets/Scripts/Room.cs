using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.tag == "Player"){
             if(gameObject != gameManager.randomRoom){
                gameManager.roomText.SetActive(true);
               
            }
           
            
        }
    }
    private void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            
                gameManager.roomText.SetActive(false);           
        }
    } 
}
