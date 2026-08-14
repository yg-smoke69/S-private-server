using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C87")]
public struct PreviewShowAvatarParams
{
	[Token(Token = "0x4010FEA")]
	[FieldOffset(Offset = "0x0")]
	public uint AvatarID;

	[Token(Token = "0x4010FEB")]
	[FieldOffset(Offset = "0x4")]
	public List<uint> ClothList;

	[Token(Token = "0x4010FEC")]
	[FieldOffset(Offset = "0x8")]
	public uint WeaponID;

	[Token(Token = "0x4010FED")]
	[FieldOffset(Offset = "0xC")]
	public uint PetID;

	[Token(Token = "0x4010FEE")]
	[FieldOffset(Offset = "0x10")]
	public bool NeedShowAnim;

	[Token(Token = "0x4010FEF")]
	[FieldOffset(Offset = "0x11")]
	public bool NeedOptionalDownload;

	[Token(Token = "0x4010FF0")]
	[FieldOffset(Offset = "0x12")]
	public bool NeedClearUI;

	[Token(Token = "0x4010FF1")]
	[FieldOffset(Offset = "0x14")]
	public List<uint> CheckOptionalIds;
}
