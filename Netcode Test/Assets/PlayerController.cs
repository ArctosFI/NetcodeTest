using Unity.Netcode;
using UnityEngine;

namespace NetcodeTest
{
    public class PlayerController : NetworkBehaviour
    {
        [SerializeField] float speed;

        private void Update()
        {
            if (IsLocalPlayer)
            {
                Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
                Vector3 velocity = input * speed * Time.deltaTime;
                transform.position += velocity;
            }
        }
    }
}