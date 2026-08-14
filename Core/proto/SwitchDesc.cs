using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AE7")]
public class SwitchDesc
{
	[Token(Token = "0x400A929")]
	[FieldOffset(Offset = "0x8")]
	public ESwitch.SwitchFunc id;

	[Token(Token = "0x400A92A")]
	[FieldOffset(Offset = "0xC")]
	public bool is_open;

	[Token(Token = "0x400A92B")]
	[FieldOffset(Offset = "0x10")]
	public string content;

	[Token(Token = "0x400A92C")]
	[FieldOffset(Offset = "0x18")]
	public long open_start_time;

	[Token(Token = "0x400A92D")]
	[FieldOffset(Offset = "0x20")]
	public long open_end_time;

	[Token(Token = "0x6008142")]
	[Address(RVA = "0x33E3218", Offset = "0x33E3218", VA = "0x33E3218")]
	public SwitchDesc()
	{
	}
}
