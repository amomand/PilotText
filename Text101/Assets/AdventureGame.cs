using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = ("Placeholder text, added programmatically");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
