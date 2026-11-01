using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
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

        if(other.gameObject.tag == "Room"){
             if(gameObject != gameManager.randomObject){
                gameManager.objectText.SetActive(true);
               Invoke("RemoveObject", 3);
               // Destroy(gameObject);
                
            }
        }
        
     }
     private void RemoveObject(){
        Destroy(gameObject);
     }
    private void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.tag == "Room"){
            
        gameManager.objectText.SetActive(false);           
        }
    }
    
}
