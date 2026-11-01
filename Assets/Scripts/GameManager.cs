using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    
    public GameObject randomObject;
    public GameObject randomRoom;
    public GameObject randomPerson;

    public GameObject titleScreen;
    public GameObject winText;
    public GameObject roomText;
    public GameObject objectText;
    public GameObject personText;

    public GameObject startBtn;

    public bool gameStarted = false;

    //objects, store all objects with a number inside the array

   // public int[] objects = {0, 1, 2, 3, 4};

   

   // public GameObject[] myObjects = {Hammer, Ball, Latter, Paper, Rope};
      public GameObject[] myObjects = new GameObject[6];
      public GameObject[] myRooms = new GameObject[9];
      public GameObject[] myPersons = new GameObject[6];

   
    
    // Start is called before the first frame update
    void Start()
    {
        GenerateRandomObjects();
        GenerateRandomRooms();
        GenerateRandomPersons();
       
    }

    // Update is called once per frame
    void Update()
    {
         
    }
     public void GenerateRandomRooms(){
      randomPerson = myPersons[Random.Range(0, myPersons.Length)];
    }
    public void GenerateRandomPersons(){
      randomRoom = myRooms[Random.Range(0, myRooms.Length)];
    }

    public void GenerateRandomObjects(){

       
       //choose a random object
         randomObject = myObjects[Random.Range(0, myObjects.Length)];
       
       /*  switch(randomObject){
            case 0:
               // choosenObject = Rope;
                choosenObject = myObjects[0];
               
                break;
            case 1:
               // choosenObject = Hammer;
                choosenObject = myObjects[1];
                break;
            case 2:
               // choosenObject = Ball;
                choosenObject = myObjects[2];
                break;
            case 3:
              // choosenObject = Latter;
               choosenObject = myObjects[3];
                break; 
            default:
              // choosenObject = Paper;
                break;
        } */
     
       
        
    }
    public void RemoveObjectAndPerson(GameObject gameObject){
      Destroy(gameObject, 3f);
    }
    public void Win(){
      winText.SetActive(true);
    }

    public void RestartGame(){
      SceneManager.LoadScene("Game");
    }
    public void StartGame(){
      titleScreen.SetActive(false);
      gameStarted = true;
    }

}
