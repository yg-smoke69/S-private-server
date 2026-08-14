using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001933")]
public class CSClaimChummyIntimacyAwardReq
{
	[Token(Token = "0x4009F13")]
	[FieldOffset(Offset = "0x8")]
	public ulong chummy_id;

	[Token(Token = "0x4009F14")]
	[FieldOffset(Offset = "0x10")]
	public EChummy.MultiRelationType multi_relation_type;

	[Token(Token = "0x4009F15")]
	[FieldOffset(Offset = "0x14")]
	public EChummy.Role role;

	[Token(Token = "0x4009F16")]
	[FieldOffset(Offset = "0x18")]
	public uint rank;

	[Token(Token = "0x6007F8C")]
	[Address(RVA = "0x317E560", Offset = "0x317E560", VA = "0x317E560")]
	public CSClaimChummyIntimacyAwardReq()
	{
	}
}
