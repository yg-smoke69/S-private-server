using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001526")]
public class wpIdAndKill
{
	[Token(Token = "0x40091E1")]
	[FieldOffset(Offset = "0x8")]
	public uint wp_id;

	[Token(Token = "0x40091E2")]
	[FieldOffset(Offset = "0xC")]
	public uint kills;

	[Token(Token = "0x40091E3")]
	[FieldOffset(Offset = "0x10")]
	public bool pre_cdt_triggered;

	[Token(Token = "0x40091E4")]
	[FieldOffset(Offset = "0x14")]
	public uint wp_type;

	[Token(Token = "0x6007B6F")]
	[Address(RVA = "0x33E6D84", Offset = "0x33E6D84", VA = "0x33E6D84")]
	public wpIdAndKill()
	{
	}
}
