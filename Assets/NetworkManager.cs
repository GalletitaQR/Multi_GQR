using Photon.Pun;
using UnityEngine;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Conectado al servidor de Photon.");
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Unirse a una sala falló. Creando una nueva.");
        PhotonNetwork.CreateRoom(null, new Photon.Realtime.RoomOptions());
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Unido a la sala.");
        // Crea una instancia del prefab "Jugador" ubicado en la carpeta Resources
        PhotonNetwork.Instantiate("Jugador", Vector3.zero, Quaternion.identity);
    }
}
