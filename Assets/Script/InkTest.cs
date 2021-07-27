using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using Ink.Runtime;

public class InkTest : MonoBehaviour
{

    public TextAsset inkAsset;
    public Story m_TestStory;
    public LocalizationAsset localizationAsset;
    public LocalizedObject localizedObject;

    private void Awake()
    {
        localizedObject.SetReference("InkText", "1");
        inkAsset = localizedObject.LoadAsset() as TextAsset;
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
