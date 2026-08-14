using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001390")]
public class BasicEPInfo
{
	[Token(Token = "0x40089FA")]
	[FieldOffset(Offset = "0x8")]
	public uint ep_event_id;

	[Token(Token = "0x40089FB")]
	[FieldOffset(Offset = "0xC")]
	public bool owned_pass;

	[Token(Token = "0x40089FC")]
	[FieldOffset(Offset = "0x10")]
	public uint ep_badge;

	[Token(Token = "0x40089FD")]
	[FieldOffset(Offset = "0x14")]
	public uint badge_cnt;

	[Token(Token = "0x6007A8C")]
	[Address(RVA = "0x317B71C", Offset = "0x317B71C", VA = "0x317B71C")]
	public BasicEPInfo()
	{
	}
}
