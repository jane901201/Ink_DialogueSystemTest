using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
public class DialogueSaveData
{
    Story m_TemStory;
    string savedJson;

    public void SaveStory()
    {
        savedJson = m_TemStory.state.ToJson();
    }

    public void LoadStory()
    {
        m_TemStory.state.LoadJson(savedJson);
    }

}
