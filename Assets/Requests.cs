using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Requests 
{

}
[System.Serializable]
public class Register
{
    public string Email;
    public string Password;
    public string Password_confirmation;
}
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Login
{
    public string access_token;
    public string token_type;
    public int expires_in;
    public string userName;

    
    public string issued;

    public string expires;
}


