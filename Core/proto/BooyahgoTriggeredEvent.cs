using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200184F")]
public class BooyahgoTriggeredEvent
{
	[Token(Token = "0x4009CAF")]
	[FieldOffset(Offset = "0x8")]
	public EMiniGame.BooyahgoNodeType type;

	[Token(Token = "0x4009CB0")]
	[FieldOffset(Offset = "0xC")]
	public uint triggered_index;

	[Token(Token = "0x6007EA9")]
	[Address(RVA = "0x317D000", Offset = "0x317D000", VA = "0x317D000")]
	public BooyahgoTriggeredEvent()
	{
	}
}
