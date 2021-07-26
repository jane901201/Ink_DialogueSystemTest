using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class InkTest : MonoBehaviour
{

    public TextAsset inkAsset;
    public Story m_TestStory;

    private void Awake()
    {
        m_TestStory = new Story(inkAsset.text);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
