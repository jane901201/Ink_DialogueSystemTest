using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUI : IUIInterface
{

    [SerializeField] private Text m_Sentence;
    [SerializeField] private Sprite m_Avater;
    [SerializeField] private Button m_ButtonA;
    [SerializeField] private Button m_ButtonB;
    [SerializeField] private Button m_ButtonC;
    [SerializeField] private Button m_ButtonD;

    public Button ButtonA { get => m_ButtonA; set => m_ButtonA = value; }
    public Button ButtonB { get => m_ButtonB; set => m_ButtonB = value; }
    public Button ButtonC { get => m_ButtonC; set => m_ButtonC = value; }
    public Button ButtonD { get => m_ButtonD; set => m_ButtonD = value; }

    public void ShowButton()
    {

    }

    public void SetSenence(Text sentence)
    {
        m_Sentence = sentence;
    }

    public void CreateChoiceView(Button btn, string text)
    {

        Text choiceText = btn.GetComponentInChildren<Text>();
        choiceText.text = text;    
    }

}
