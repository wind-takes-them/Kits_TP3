using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class Appeler_API : MonoBehaviour
{
    private TMP_InputField placefortext;
    private TouchScreenKeyboard keyboard;
    private string wordinput;

    private void Start()
        {

        //placefortext = this.gameObject.GetComponent<InputField>();
        placefortext = GetComponentInChildren<TMP_InputField>();

    }



    public void ShowKeyboard()
    {
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
        Debug.Log("a thaa keeeyboard");
    }



    public void written()
    {
        wordinput=placefortext.text.ToString();
        Debug.Log(wordinput);
    }








}
