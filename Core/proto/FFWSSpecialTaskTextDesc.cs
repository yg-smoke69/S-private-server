using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B91")]
public class FFWSSpecialTaskTextDesc
{
	[Token(Token = "0x400AD5B")]
	[FieldOffset(Offset = "0x8")]
	public uint index;

	[Token(Token = "0x400AD5C")]
	[FieldOffset(Offset = "0xC")]
	public uint activity_id;

	[Token(Token = "0x400AD5D")]
	[FieldOffset(Offset = "0x10")]
	public string task_text1;

	[Token(Token = "0x400AD5E")]
	[FieldOffset(Offset = "0x14")]
	public string task_text2;

	[Token(Token = "0x400AD5F")]
	[FieldOffset(Offset = "0x18")]
	public string task_text3;

	[Token(Token = "0x400AD60")]
	[FieldOffset(Offset = "0x1C")]
	public string task_text4;

	[Token(Token = "0x400AD61")]
	[FieldOffset(Offset = "0x20")]
	public string task_text5;

	[Token(Token = "0x60081EC")]
	[Address(RVA = "0x30A0700", Offset = "0x30A0700", VA = "0x30A0700")]
	public FFWSSpecialTaskTextDesc()
	{
	}
}
