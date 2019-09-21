using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class PressB : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject back_cover_label; //information about the book 
    public GameObject back_cover_txt; //text for Press 
    public GameObject vButton; //the actual virtual button 
    public GameObject videoQuad;  //the video the book review
    public GameObject review_text;  //the book reviews 


    // Start is called before the first frame update
    void Start()
    {
        vButton = GameObject.Find("VirtualButton"); 
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this); 

        //find the objects in Vuforia 
        back_cover_txt = GameObject.Find("MyText"); 
        videoQuad = GameObject.Find("VideoQuad");
        review_text = GameObject.Find("Reviews"); 


        videoQuad.SetActive(false);  
        review_text.SetActive(false); 

    }

    //show the contents when the button is pressed 
    public void OnButtonPressed(VirtualButtonBehaviour vb) { 
        back_cover_label.SetActive(true); 
         back_cover_txt.SetActive(false); 
         videoQuad.SetActive(true); 
         review_text.SetActive(true); 
    }
    
    //remove the contents when the button is released 
    public void OnButtonReleased(VirtualButtonBehaviour vb) { 
        back_cover_label.SetActive(false); 
        back_cover_txt.SetActive(true);
        videoQuad.SetActive(false); 
        review_text.SetActive(false); 
    }

    
}
