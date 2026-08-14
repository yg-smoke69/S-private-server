using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20012F8")]
public class ActivationStatusReq
{
	[Token(Token = "0x40085B7")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40085B8")]
	[FieldOffset(Offset = "0x10")]
	public string lock_region;

	[Token(Token = "0x40085B9")]
	[FieldOffset(Offset = "0x14")]
	public string client_version;

	[Token(Token = "0x40085BA")]
	[FieldOffset(Offset = "0x18")]
	public uint plat_id;

	[Token(Token = "0x40085BB")]
	[FieldOffset(Offset = "0x1C")]
	public bool is_trial;

	[Token(Token = "0x6007A45")]
	[Address(RVA = "0x3179E44", Offset = "0x3179E44", VA = "0x3179E44")]
	public ActivationStatusReq()
	{
	}
}
