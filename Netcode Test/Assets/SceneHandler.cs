using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.SceneManagement;

public class SceneHandler : NetworkBehaviour
{
    private void Awake()
    {
        NetworkManager.OnServerStarted += LoadLobby;
    }

    void LoadLobby()
    {
        NetworkManager.SceneManager.LoadScene("OtherScene", LoadSceneMode.Single);
    }
}
