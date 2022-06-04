using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handContr : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    GameObject PressE;
    GameObject letter;
    GameObject hand;
    Transform letTR;
    Transform handTR;
    void Start()
    {
        PressE=GameObject.Find("PressE");
        PressE.SetActive(false);

        letter=GameObject.Find("letter");
        hand=GameObject.Find("hand");

        letTR=letter.GetComponent<Transform>();
        handTR=hand.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        PressE.SetActive(false);
        Debug.DrawRay(cam.transform.position, cam.transform.forward*4f, Color.red);
        RaycastHit touch;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out touch, 4)){
            if(touch.transform.gameObject.tag=="letter"){
                PressE.SetActive(true);
                if(Input.GetKeyDown("e")){
                    print("i take it");
                    if(letter.GetComponent<Rigidbody>()){
                        Destroy(letter.GetComponent<Rigidbody>());
                    }
                    letTR.position=handTR.position;
                    letTR.rotation=handTR.rotation;
                    letTR.SetParent(handTR);
                }
            }

        }
        if(Input.GetKeyDown("f")){
            if(letTR.position==handTR.position){
                print("drop");
                letTR.parent=null;
                letter.AddComponent<Rigidbody>();
                letter.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*500f);
            }
            
        }
    }
}
