using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AC3")]
public class PayLevelPoolDesc
{
	[Token(Token = "0x400A88B")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A88C")]
	[FieldOffset(Offset = "0xC")]
	public uint unique_id;

	[Token(Token = "0x400A88D")]
	[FieldOffset(Offset = "0x10")]
	public uint start_time;

	[Token(Token = "0x400A88E")]
	[FieldOffset(Offset = "0x14")]
	public uint end_time;

	[Token(Token = "0x6008120")]
	[Address(RVA = "0x33DF228", Offset = "0x33DF228", VA = "0x33DF228")]
	public PayLevelPoolDesc()
	{
	}
}
