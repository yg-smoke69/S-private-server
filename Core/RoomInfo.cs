using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000D44")]
public class RoomInfo : _Attribute
{
	[Token(Token = "0x4006B1E")]
	[FieldOffset(Offset = "0x8")]
	public string RoomID;

	[Token(Token = "0x4006B1F")]
	[FieldOffset(Offset = "0xC")]
	public string UserID;

	[Token(Token = "0x4006B20")]
	[FieldOffset(Offset = "0x10")]
	public string Tag;

	[Token(Token = "0x6006582")]
	[Address(RVA = "0x316CC30", Offset = "0x316CC30", VA = "0x316CC30")]
	public RoomInfo()
	{
	}

	[Token(Token = "0x6006583")]
	[Address(RVA = "0x316CCE8", Offset = "0x316CCE8", VA = "0x316CCE8")]
	public RoomInfo(string roomID, string userID, string tag = "")
	{
	}

	[Token(Token = "0x6006584")]
	[Address(RVA = "0x316CE9C", Offset = "0x316CE9C", VA = "0x316CE9C", Slot = "4")]
	public bool Equals(RoomInfo other)
	{
		return default(bool);
	}
}
