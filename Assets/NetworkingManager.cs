using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.WebRequestMethods;
using UnityEngine.Networking;
using UnityEditor.ShaderGraph.Serialization;
using UnityEngine.UI;
using TMPro;
using System;



public class NetworkingManager : MonoBehaviour
{

    public static NetworkingManager instance;
    public static Login logIn;

    public string baseURL = @"https://unitybackend20240806110843.azurewebsites.net/api/";
    public string loginBaseURL = @"https://unitybackend20240806110843.azurewebsites.net/";

    public TMP_InputField emailInputFiled;  // Change to TMP_InputField
    public TMP_InputField passwordInputFiled;  // Change to TMP_InputField
    public TMP_InputField confirmPasswordInputFiled;
   
    public TMP_InputField loginEmailInputFiled;  // Change to TMP_InputField
    public TMP_InputField loginPasswordInputFiled;



    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void OnRegButton()
    {
        Register tempReg = new Register() { Email = emailInputFiled.text, Password = passwordInputFiled.text, Password_confirmation = confirmPasswordInputFiled.text };
        StartCoroutine(Register(tempReg));
        
    }
    public void OnLogInButton()
    {
        StartCoroutine(Login());   
    }

    public IEnumerator Register(Register Register)
    {
        var uwr = new UnityWebRequest(baseURL + "Account/Register", "POST");
        string jsonData = JsonUtility.ToJson(Register);

        byte[] jsonToSend = new System.Text.UTF8Encoding().GetBytes(jsonData);

        uwr.uploadHandler = (UploadHandler)new UploadHandlerRaw(jsonToSend);
        uwr.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();

        uwr.SetRequestHeader("Content-Type", "application/json");
        yield return uwr.SendWebRequest();

        if (uwr.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log("Error: " + uwr.error);
        }
        else
        {
            Debug.Log(uwr.downloadHandler.text);

        }
    }
    public IEnumerator Login()
    {
        WWWForm form = new WWWForm();

        form.AddField("grant_type", "password");
        form.AddField("username", loginEmailInputFiled.text);
        form.AddField("Password",loginPasswordInputFiled.text);

        UnityWebRequest uwr = UnityWebRequest.Post(loginBaseURL+"token",form);
        yield return uwr.SendWebRequest();

        if (uwr.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log("Error: " + uwr.error);
        }
        else
        {
            Debug.Log(uwr.downloadHandler.text);
            
            logIn = JsonUtility.FromJson<Login>(uwr.downloadHandler.text);
            StartCoroutine(SaveData());
        }
    }


    public IEnumerator SaveData()
    {
       WWWForm form = new WWWForm();

       form.AddField("username", loginEmailInputFiled.text);
       form.AddField("UserData", "{score-15}");

       form.headers.Add("Authorization", "Bearer " + logIn.access_token);

       UnityWebRequest uwr = UnityWebRequest.Post(baseURL + "userprofile", form);
       yield return uwr.SendWebRequest();

       if (uwr.result == UnityWebRequest.Result.ConnectionError)
       {
            Debug.Log("Error: " + uwr.error);
       }
       else
       {
            Debug.Log(uwr.downloadHandler.text);

            logIn = JsonUtility.FromJson<Login>(uwr.downloadHandler.text);
       }

    }
}