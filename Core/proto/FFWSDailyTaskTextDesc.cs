using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B90")]
public class FFWSDailyTaskTextDesc
{
	[Token(Token = "0x400AD54")]
	[FieldOffset(Offset = "0x8")]
	public uint index;

	[Token(Token = "0x400AD55")]
	[FieldOffset(Offset = "0xC")]
	public uint activity_time;

	[Token(Token = "0x400AD56")]
	[FieldOffset(Offset = "0x10")]
	public string task_text1;

	[Token(Token = "0x400AD57")]
	[FieldOffset(Offset = "0x14")]
	public string task_text2;

	[Token(Token = "0x400AD58")]
	[FieldOffset(Offset = "0x18")]
	public string task_text3;

	[Token(Token = "0x400AD59")]
	[FieldOffset(Offset = "0x1C")]
	public string task_text4;

	[Token(Token = "0x400AD5A")]
	[FieldOffset(Offset = "0x20")]
	public string task_text5;

	[Token(Token = "0x60081EB")]
	[Address(RVA = "0x30A03B0", Offset = "0x30A03B0", VA = "0x30A03B0")]
	public FFWSDailyTaskTextDesc()
	{
	}
}
