using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B2E")]
public class CustomEventTemplateDesc
{
	[Token(Token = "0x400AADD")]
	[FieldOffset(Offset = "0x8")]
	public uint custom_event_id;

	[Token(Token = "0x400AADE")]
	[FieldOffset(Offset = "0xC")]
	public string config_key;

	[Token(Token = "0x400AADF")]
	[FieldOffset(Offset = "0x10")]
	public string param1;

	[Token(Token = "0x400AAE0")]
	[FieldOffset(Offset = "0x14")]
	public string param2;

	[Token(Token = "0x400AAE1")]
	[FieldOffset(Offset = "0x18")]
	public string param3;

	[Token(Token = "0x400AAE2")]
	[FieldOffset(Offset = "0x1C")]
	public string param4;

	[Token(Token = "0x6008189")]
	[Address(RVA = "0x309E308", Offset = "0x309E308", VA = "0x309E308")]
	public CustomEventTemplateDesc()
	{
	}
}
