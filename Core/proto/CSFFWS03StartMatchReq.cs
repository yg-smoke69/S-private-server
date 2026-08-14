using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200189F")]
public class CSFFWS03StartMatchReq
{
	[Token(Token = "0x4009D61")]
	[FieldOffset(Offset = "0x8")]
	public uint match_id;

	[Token(Token = "0x4009D62")]
	[FieldOffset(Offset = "0xC")]
	public uint match_state;

	[Token(Token = "0x4009D63")]
	[FieldOffset(Offset = "0x10")]
	public uint sword_value;

	[Token(Token = "0x4009D64")]
	[FieldOffset(Offset = "0x14")]
	public uint policy_value;

	[Token(Token = "0x6007EF8")]
	[Address(RVA = "0x3180320", Offset = "0x3180320", VA = "0x3180320")]
	public CSFFWS03StartMatchReq()
	{
	}
}
