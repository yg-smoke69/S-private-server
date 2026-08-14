using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A9B")]
public class TeleportDoorGroup : MonoBehaviour
{
	[Token(Token = "0x4005CEF")]
	[FieldOffset(Offset = "0xC")]
	public LevelTeleportDoor[] levelTeleportDoors;

	[Token(Token = "0x4005CF0")]
	[FieldOffset(Offset = "0x10")]
	public bool ProvideBuff;

	[Token(Token = "0x4005CF1")]
	[FieldOffset(Offset = "0x14")]
	public int BuffID;

	[Token(Token = "0x600514D")]
	[Address(RVA = "0x21DCE3C", Offset = "0x21DCE3C", VA = "0x21DCE3C")]
	public TeleportDoorGroup()
	{
	}

	[Token(Token = "0x600514E")]
	[Address(RVA = "0x21DCE44", Offset = "0x21DCE44", VA = "0x21DCE44")]
	public void CheckGroupIsValid()
	{
	}

	[Token(Token = "0x600514F")]
	[Address(RVA = "0x21DCFC4", Offset = "0x21DCFC4", VA = "0x21DCFC4")]
	private void LogError(string message)
	{
	}
}
