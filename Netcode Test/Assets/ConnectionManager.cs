using Unity.Netcode;
using UnityEngine;
using TMPro;
using Unity.Netcode.Transports.UTP;

public class ConnectionManager : MonoBehaviour
{
    [SerializeField] TMP_InputField iptext;

    [SerializeField] NetworkManager nm;
    [SerializeField] UnityTransport utp;

    public void Host()
    {
        nm.StartHost();
        gameObject.SetActive(false);
    }

    public void Join()
    {
        utp.SetConnectionData(iptext.text, 7777);
        nm.StartClient();
        gameObject.SetActive(false);
    }
}
