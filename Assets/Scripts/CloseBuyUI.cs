using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBuyUI : MonoBehaviour
{
    [SerializeField] Animator animator;
    
    // Start is called before the first frame update
    public void OnClose()
    {
        animator.SetTrigger("SlideOut");

    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
