using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodyDoor : Interactable
{
    // [Tooltip("Visible distance before blood starts showing")]
    // public float bloodMinDist;

    PlayerCharacterController m_player;
    bool m_opened;
    // MeshRenderer m_renderer;

    // Start is called before the first frame update
    void Start()
    {
        // m_player = FindObjectOfType<PlayerCharacterController>();
        // m_opened = false;
    }

    // void Update(){
    //     if(!m_opened){
    //         return;
    //     }

    // //     // float dist = Vector3.Distance(this.transform.position, m_player.transform.position);
    // //     // if (dist < bloodMinDist){
            
    // //     //     // Shader shader = Shader.Find("Bloody/Doors");
    // //     //     // Material material = new Material(Shader.Find("Bloody/Doors"));
    // //     //     // foreach(string strvar in shader.GetPropertyAttributes(8)){
    // //     //     Debug.Log(m_renderer.material.GetFloat("_BloodAmount"));
    // //     //     // }
            
    // //     //     // shader.SetFloat("_BloodAmount", 1);
    // //     //     m_renderer.material.SetFloat("_BloodAmount", 0.5f);
    // //     //     // material.SetFloat("_BloodAmount", 1);

    // //     // }
    // }

    public override void Interact(){
        this.GetComponent<Animator>().SetBool("open", true); //open door
        // LoadNextLevel();
    }
}
