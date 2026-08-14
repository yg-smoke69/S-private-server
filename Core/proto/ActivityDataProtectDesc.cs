using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019DA")]
public class ActivityDataProtectDesc
{
	[Token(Token = "0x400A22C")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A22D")]
	[FieldOffset(Offset = "0xC")]
	public bool is_open;

	[Token(Token = "0x6008032")]
	[Address(RVA = "0x317A0F4", Offset = "0x317A0F4", VA = "0x317A0F4")]
	public ActivityDataProtectDesc()
	{
	}
}
