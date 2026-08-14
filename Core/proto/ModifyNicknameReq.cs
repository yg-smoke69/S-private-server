using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001366")]
public class ModifyNicknameReq
{
	[Token(Token = "0x40088DD")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40088DE")]
	[FieldOffset(Offset = "0x10")]
	public string nickname;

	[Token(Token = "0x40088DF")]
	[FieldOffset(Offset = "0x14")]
	public string lock_region;

	[Token(Token = "0x40088E0")]
	[FieldOffset(Offset = "0x18")]
	public string noti_region;

	[Token(Token = "0x40088E1")]
	[FieldOffset(Offset = "0x1C")]
	public bool use_card;

	[Token(Token = "0x40088E2")]
	[FieldOffset(Offset = "0x20")]
	public string ip_address;

	[Token(Token = "0x40088E3")]
	[FieldOffset(Offset = "0x24")]
	public uint client_type;

	[Token(Token = "0x6007A67")]
	[Address(RVA = "0x30A8CFC", Offset = "0x30A8CFC", VA = "0x30A8CFC")]
	public ModifyNicknameReq()
	{
	}
}
