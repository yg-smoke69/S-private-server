using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002AF2")]
public class FRoomModeSelectData
{
	[Token(Token = "0x40107A4")]
	[FieldOffset(Offset = "0x8")]
	public EMatch.GameMode gamemode;

	[Token(Token = "0x40107A5")]
	[FieldOffset(Offset = "0xC")]
	public EMatch.GroupMode groupMode;

	[Token(Token = "0x40107A6")]
	[FieldOffset(Offset = "0x10")]
	public bool select;

	[Token(Token = "0x40107A7")]
	[FieldOffset(Offset = "0x14")]
	public string name;

	[Token(Token = "0x40107A8")]
	[FieldOffset(Offset = "0x18")]
	public string icon;

	[Token(Token = "0x60119FF")]
	[Address(RVA = "0x2303538", Offset = "0x2303538", VA = "0x2303538")]
	public FRoomModeSelectData()
	{
	}
}
