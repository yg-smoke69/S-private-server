using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E37")]
public abstract class AkSpatialAudioBase : MonoBehaviour
{
	[Token(Token = "0x401A56B")]
	[FieldOffset(Offset = "0xC")]
	private readonly AkRoom.PriorityList roomPriorityList;

	[Token(Token = "0x60194B8")]
	[Address(RVA = "0x2EB6A58", Offset = "0x2EB6A58", VA = "0x2EB6A58")]
	protected AkSpatialAudioBase()
	{
	}

	[Token(Token = "0x60194B9")]
	[Address(RVA = "0x2EB6AD4", Offset = "0x2EB6AD4", VA = "0x2EB6AD4")]
	protected void SetGameObjectInHighestPriorityRoom()
	{
	}

	[Token(Token = "0x60194BA")]
	[Address(RVA = "0x2EB6BA4", Offset = "0x2EB6BA4", VA = "0x2EB6BA4")]
	public void EnteredRoom(AkRoom room)
	{
	}

	[Token(Token = "0x60194BB")]
	[Address(RVA = "0x2EB6BE4", Offset = "0x2EB6BE4", VA = "0x2EB6BE4")]
	public void ExitedRoom(AkRoom room)
	{
	}

	[Token(Token = "0x60194BC")]
	[Address(RVA = "0x2EB6C24", Offset = "0x2EB6C24", VA = "0x2EB6C24")]
	public void SetGameObjectInRoom()
	{
	}
}
