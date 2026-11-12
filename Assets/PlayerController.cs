using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviourPunCallbacks
{
    private void Update()
    {
        if (photonView.IsMine)
        {
            float move = 0f;

            // Detecta teclas A/D o Flechas Izquierda/Derecha en Unity 6
            if (Keyboard.current != null)
            {
                if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
                    move = -1f;
                if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
                    move = 1f;
            }

            transform.Translate(move * Time.deltaTime * 5f, 0, 0);
        }
    }
}
