using JetBrains.Annotations;
using Proyecto26;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using static System.Net.WebRequestMethods;


[Serializable]
public class ApiResponse
{
    public Complementary complementary;
}

[Serializable]
public class Base
{
    public string keyword;
}

[Serializable]
public class Complementary // Corrected class name
{
    public string keyword;
    public RGB rgb; // Corrected class name
}

[Serializable]
public class RGB // Corrected class name
{
    public string value;
    public Composition composition; // Corrected class name
}

[Serializable]
public class Composition // Corrected class name
{
    public string red;
    public string green;
    public string blue;
}


public class Implementation_API : MonoBehaviour
{
    public string urlAPI = "";
    public ApiResponse response; // Corrected class name

    void Start()
    {
        RestClient.Get(new RequestHelper
        {
            Uri = "https://color.serialif.com/85,102,119",
            Headers = new Dictionary<string, string>
            {
                { "Accept", "application/json" },
            }
        }).Then(response =>
        {
            Debug.Log(response.Text);
            this.response = JsonUtility.FromJson<ApiResponse>(response.Text);

        }).Catch(error =>
        {
            Debug.LogError("Error: " + error);
        });
    }

    private void Update()
    {
        //Debug.Log(response.complementary.rgb.composition.red);
        //Debug.Log(response.complementary.keyword);
    }

}
