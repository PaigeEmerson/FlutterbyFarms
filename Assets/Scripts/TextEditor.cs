using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextEditor : MonoBehaviour
{
    public TextMeshProUGUI myText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void EditNumber(int num)
    {
        myText.text = num.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        EditNumber(GameManagerScript.Instance.daysPassed);
    }
}
