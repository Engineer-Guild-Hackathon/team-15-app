using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine.SceneManagement;

public class CreateJoin : MonoBehaviourPunCallbacks
{
    private bool isConnectedToMaster = false;
    public TMP_InputField RoomName;

    void Start()
    {
        // �v���C���[���͐ݒ肵�Ȃ��i�󕶎��ɂ���j
        PhotonNetwork.NickName = "";

        // Photon�̃��[�W��������{�ɐݒ�
        PhotonNetwork.PhotonServerSettings.AppSettings.FixedRegion = "jp";

        if (!PhotonNetwork.IsConnected)
        {
            // "Connecting"�V�[�������[�h
            SceneManager.LoadScene("Connecting", LoadSceneMode.Additive);

            PhotonNetwork.ConnectUsingSettings();
            Debug.Log("Photon�ɐڑ���...");
        }

        // �t�@�C�A�[�E�H�[���̏�����
        PlayerPrefs.SetString("BlockedIP", "");
        PlayerPrefs.SetString("BlockedIPMyServer", "");
        PlayerPrefs.Save();
    }

    public override void OnConnectedToMaster()
    {
        isConnectedToMaster = true;
        Debug.Log("Photon�ɐڑ������I �}�X�^�[�T�[�o�[�ɐڑ����܂����B");

        // "Connecting"�V�[�����A�����[�h
        SceneManager.UnloadSceneAsync("Connecting");
    }

    public void JoinRoom()
    {
        if (!isConnectedToMaster)
        {
            Debug.LogError("Photon�ɂ܂��ڑ�����Ă��܂���B�ڑ�����������܂ő҂��Ă��������B");
            return;
        }

        string roomName = RoomName.text;
        if (string.IsNullOrEmpty(roomName))
        {
            Debug.LogError("���[��������͂��Ă��������B");
            return;
        }

        // ���[���ɎQ�������݂�
        PhotonNetwork.JoinRoom(roomName);
        Debug.Log($"���[�� '{roomName}' �ɎQ����...");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        // ���[���ɎQ���ł��Ȃ������ꍇ�A�V�������[�����쐬
        Debug.LogWarning($"���[�� '{RoomName.text}' �ւ̎Q���Ɏ��s: {message}");

        string roomName = RoomName.text;
        if (string.IsNullOrEmpty(roomName))
        {
            roomName = "Room_" + Random.Range(1000, 9999); // �����_���ȃ��[�����𐶐�
        }

        RoomOptions roomOptions = new RoomOptions
        {
            MaxPlayers = 6,
            IsVisible = true,
            IsOpen = true
        };

        PhotonNetwork.CreateRoom(roomName, roomOptions);
        Debug.Log($"�V�������[�� '{roomName}' ���쐬��...");
    }

    public override void OnJoinedRoom()
    {
        // ���[���ɎQ�����������ꍇ�̏���
        Debug.Log("���[���ɎQ�������I");
        SceneManager.LoadScene("Waiting"); // "Waiting"�V�[���ɑJ��
        Debug.Log($"���ݎQ�����Ă��郋�[���̖��O: {PhotonNetwork.CurrentRoom.Name}");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        // ���[���쐬�Ɏ��s�����ꍇ�̏����i�Ⴆ�Γ����̃��[�������łɑ��݂���ꍇ�j
        Debug.LogError($"���[���쐬���s: {message}");
    }
}