using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C7B")]
public class ShowBoostAvatarParams
{
	[Token(Token = "0x2002C7C")]
	public delegate BoostState CheckBoostStateDelegate(uint itemID);

	[Token(Token = "0x4010FC3")]
	[FieldOffset(Offset = "0x8")]
	public CheckBoostStateDelegate CheckBoostState;

	[Token(Token = "0x60128FC")]
	[Address(RVA = "0x20E67C4", Offset = "0x20E67C4", VA = "0x20E67C4")]
	public ShowBoostAvatarParams()
	{
	}
}
