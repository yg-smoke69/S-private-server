using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200159F")]
public class CSChooseEmoteReq
{
	[Token(Token = "0x40093BB")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x40093BC")]
	[FieldOffset(Offset = "0xC")]
	public uint emote_id;

	[Token(Token = "0x40093BD")]
	[FieldOffset(Offset = "0x10")]
	public ulong group_id;

	[Token(Token = "0x6007BE7")]
	[Address(RVA = "0x317E2EC", Offset = "0x317E2EC", VA = "0x317E2EC")]
	public CSChooseEmoteReq()
	{
	}
}
