using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001894")]
public class FFWS03ClaimedMilestoneInfo
{
	[Token(Token = "0x4009D4B")]
	[FieldOffset(Offset = "0x8")]
	public uint stage_type;

	[Token(Token = "0x4009D4C")]
	[FieldOffset(Offset = "0xC")]
	public uint target;

	[Token(Token = "0x6007EED")]
	[Address(RVA = "0x30A0268", Offset = "0x30A0268", VA = "0x30A0268")]
	public FFWS03ClaimedMilestoneInfo()
	{
	}
}
