using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B19")]
public class LinkageProcessRewardsStatus
{
	[Token(Token = "0x400AA4C")]
	[FieldOffset(Offset = "0x8")]
	public uint process_id;

	[Token(Token = "0x400AA4D")]
	[FieldOffset(Offset = "0xC")]
	public EPProcess_Status status;

	[Token(Token = "0x6008174")]
	[Address(RVA = "0x30A641C", Offset = "0x30A641C", VA = "0x30A641C")]
	public LinkageProcessRewardsStatus()
	{
	}
}
