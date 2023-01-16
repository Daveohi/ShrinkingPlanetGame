using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour, IPointerClickHandler
{
   
        //Detect if a click occurs
        public void OnPointerClick(PointerEventData pointerEventData)
         {
           // GameManager.instance.Restart();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         }
}
