using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200144A")]
public class GetBasicLinkageInfoReq
{
	[Token(Token = "0x4008D28")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008D29")]
	[FieldOffset(Offset = "0x10")]
	public string lock_region;

	[Token(Token = "0x6007AF8")]
	[Address(RVA = "0x30A1E9C", Offset = "0x30A1E9C", VA = "0x30A1E9C")]
	public GetBasicLinkageInfoReq()
	{
	}
}
