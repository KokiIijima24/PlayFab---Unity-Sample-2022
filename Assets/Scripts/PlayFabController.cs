using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;

public class PlayFabController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayFabClientAPI.LoginWithCustomID(new ClientModels.LoginWithCustomIDRequest
        {
            CustomId = "GettingStartingGuide",
            CreateAccount = true
        },
        result =>
        {
            Debug.Log("おめでとうございます！ログイン成功です！");
        },
        error =>
        {
            Debug.Log("ログインに失敗(ﾉД`)");
        }
        );
    }

    private void SetUserData()
    {
        PlayFabClientAPI.UpdateUserData(new UpdateUserDataRequest
        {
            SetUserData = new Dictionary<string, string>(){
                            {"Name", "joker"},
                            {"Exp", "1000"}
            }
        }, result =>
        {
            Debug.Log("プレイヤーデータの登録に成功");
        }, error =>
        {
            Debug.log("Error");
        });
    }
}
