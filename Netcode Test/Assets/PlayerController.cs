using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : NetworkBehaviour
{
    [SerializeField] float speed;

    private void Awake()
    {
        NetworkManager.SceneManager.OnSceneEvent += SceneEvent;
    }

    private void Update()
    {
        if (IsLocalPlayer)
        {
            Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            Vector3 velocity = input * speed * Time.deltaTime;
            transform.position += velocity;
        }
    }

    void SceneEvent(SceneEvent sceneEvent)
    {
        if (sceneEvent.SceneEventType == SceneEventType.LoadEventCompleted && IsClient && IsOwner)
        {
            Debug.Log("Scene Load");
        }
    }
}