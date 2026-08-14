using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001600")]
public class VeteranRewardItem
{
	[Token(Token = "0x40094C3")]
	[FieldOffset(Offset = "0x8")]
	public VeteranRewardDesc desc;

	[Token(Token = "0x40094C4")]
	[FieldOffset(Offset = "0xC")]
	public uint status;

	[Token(Token = "0x6007C4A")]
	[Address(RVA = "0x33E477C", Offset = "0x33E477C", VA = "0x33E477C")]
	public VeteranRewardItem()
	{
	}
}
