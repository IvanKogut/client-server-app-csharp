﻿using API.Models;

namespace TodoList.Client
{
  public class ApiUrls
  {
    private const string apiUrl = "https://localhost:44388";

    public static readonly string Login = $"{apiUrl}{Urls.Users}/{Urls.Login}";
    public static readonly string SignUp = $"{apiUrl}{Urls.Users}";
    public static readonly string PasswordRecovery = $"{apiUrl}{Urls.Users}/{Urls.PasswordRecovery}";
    public static readonly string LoginByFacebook = $"{apiUrl}{Urls.Users}/{Urls.LoginByFacebook}";
    public static readonly string LoginByGoogle = $"{apiUrl}{Urls.Users}/{Urls.LoginByGoogle}";
    public static readonly string LoginByGithub = $"{apiUrl}{Urls.Users}/{Urls.LoginByGithub}";
    public static readonly string LoginByLinkedin = $"{apiUrl}{Urls.Users}/{Urls.LoginByLinkedin}";
    public static readonly string ChangePassword = $"{apiUrl}{Urls.Users}/{Urls.ChangePassword}";
    public static readonly string IsTwoFactorAuthenticationEnabled = $"{apiUrl}{Urls.Users}/{Urls.IsTwoFactorAuthenticationEnabled}";
    public static readonly string AuthenticatorUri = $"{apiUrl}{Urls.Users}/{Urls.AuthenticatorUri}";
    public static readonly string EnableTwoFactorAuthentication = $"{apiUrl}{Urls.Users}/{Urls.EnableTwoFactorAuthentication}";
    public static readonly string DisableTwoFactorAuthentication = $"{apiUrl}{Urls.Users}/{Urls.DisableTwoFactorAuthentication}";

    public static readonly string GetItemsList = $"{apiUrl}{Urls.Items}";
    public static readonly string CreateItem = $"{apiUrl}{Urls.Items}";
    public static readonly string UpdateItem = $"{apiUrl}{Urls.Items}/{Urls.UpdateItem}";
    public static readonly string DeleteItem = $"{apiUrl}{Urls.Items}/{Urls.DeleteItem}";
  }
}
