using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbySceneHandler : NetworkBehaviour
{
    [SerializeField] Button switchScene;

    private void Start()
    {
        if(IsHost) switchScene.onClick.AddListener(LoadThird);
        if (!IsHost) switchScene.GetComponentInParent<Canvas>().gameObject.SetActive(false);
    }

    void LoadThird()
    {
        NetworkManager.SceneManager.LoadScene("ThirdScene", LoadSceneMode.Single);
    }
}
