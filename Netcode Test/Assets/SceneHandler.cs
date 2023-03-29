using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.SceneManagement;

public class SceneHandler : NetworkBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void FixedUpdate()
    {
        NetworkManager.OnServerStarted += LoadLobby;
        if(Input.GetKeyDown(KeyCode.B)) NetworkManager.SceneManager.LoadScene("ThirdScene", LoadSceneMode.Single);
    }

    void LoadLobby()
    {
        NetworkManager.SceneManager.LoadScene("OtherScene", LoadSceneMode.Single);
    }
}
