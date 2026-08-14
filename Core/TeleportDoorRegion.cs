using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A9C")]
public class TeleportDoorRegion : MonoBehaviour
{
	[Token(Token = "0x4005CF2")]
	[FieldOffset(Offset = "0xC")]
	public Transform m_Transform;

	[Token(Token = "0x4005CF3")]
	[FieldOffset(Offset = "0x10")]
	public TeleportDoorGroup[] levelTeleportDoorGroups;

	[Token(Token = "0x6005150")]
	[Address(RVA = "0x21DD0E4", Offset = "0x21DD0E4", VA = "0x21DD0E4")]
	public TeleportDoorRegion()
	{
	}

	[Token(Token = "0x6005151")]
	[Address(RVA = "0x21DD0EC", Offset = "0x21DD0EC", VA = "0x21DD0EC")]
	public void CheckRegionValid()
	{
	}

	[Token(Token = "0x6005152")]
	[Address(RVA = "0x21DD204", Offset = "0x21DD204", VA = "0x21DD204")]
	private void LogError(string message)
	{
	}
}
