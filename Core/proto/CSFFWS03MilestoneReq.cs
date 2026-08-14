using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200189D")]
public class CSFFWS03MilestoneReq
{
	[Token(Token = "0x4009D5E")]
	[FieldOffset(Offset = "0x8")]
	public uint stage_type;

	[Token(Token = "0x4009D5F")]
	[FieldOffset(Offset = "0xC")]
	public uint target;

	[Token(Token = "0x6007EF6")]
	[Address(RVA = "0x3180300", Offset = "0x3180300", VA = "0x3180300")]
	public CSFFWS03MilestoneReq()
	{
	}
}
