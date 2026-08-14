using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BD3")]
public class WorkshopExpireTimeDesc
{
	[Token(Token = "0x400AF11")]
	[FieldOffset(Offset = "0x8")]
	public uint expire_type;

	[Token(Token = "0x400AF12")]
	[FieldOffset(Offset = "0xC")]
	public uint expire_time;

	[Token(Token = "0x600822E")]
	[Address(RVA = "0x33E63D4", Offset = "0x33E63D4", VA = "0x33E63D4")]
	public WorkshopExpireTimeDesc()
	{
	}
}
