using System;
using COW;
using Il2CppDummyDll;
using message;

[Serializable]
[Token(Token = "0x20002D1")]
public class UGCModeParamItem
{
	[Token(Token = "0x400330F")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4003310")]
	[FieldOffset(Offset = "0xC")]
	public string Name;

	[Token(Token = "0x4003311")]
	[FieldOffset(Offset = "0x10")]
	public OHAAMABDKEN Type;

	[Token(Token = "0x4003312")]
	[FieldOffset(Offset = "0x14")]
	public string Value;

	[Token(Token = "0x4003313")]
	[FieldOffset(Offset = "0x18")]
	public string Description;

	[Token(Token = "0x6000D96")]
	[Address(RVA = "0x2649644", Offset = "0x2649644", VA = "0x2649644")]
	public UGCModeParamItem(UGCRoomParamsItem roomParamItem)
	{
	}
}
