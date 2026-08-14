using Il2CppDummyDll;
using UnityEngine;
using WorldStreamer;

[Token(Token = "0x2003D19")]
public class PlayerTeleport : MonoBehaviour
{
	[Token(Token = "0x4019EBC")]
	[FieldOffset(Offset = "0xC")]
	public UILoadingStreamer uiLoadingStreamer;

	[Token(Token = "0x4019EBD")]
	[FieldOffset(Offset = "0x10")]
	public PlayerMover playerMover;

	[Token(Token = "0x4019EBE")]
	[FieldOffset(Offset = "0x14")]
	public Streamer[] streamers;

	[Token(Token = "0x4019EBF")]
	[FieldOffset(Offset = "0x18")]
	public Transform player;

	[Token(Token = "0x4019EC0")]
	[FieldOffset(Offset = "0x1C")]
	public WorldMover worldMover;

	[Token(Token = "0x6018768")]
	[Address(RVA = "0x1E23898", Offset = "0x1E23898", VA = "0x1E23898")]
	public PlayerTeleport()
	{
	}

	[Token(Token = "0x6018769")]
	[Address(RVA = "0x1E238A0", Offset = "0x1E238A0", VA = "0x1E238A0")]
	public void Teleport(bool showLoadingScreen)
	{
	}

	[Token(Token = "0x601876A")]
	[Address(RVA = "0x1E23DD4", Offset = "0x1E23DD4", VA = "0x1E23DD4")]
	private void OnDrawGizmosSelected()
	{
	}
}
