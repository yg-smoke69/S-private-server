using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B9C")]
public class HurricaneBLevelShow
{
	[Token(Token = "0x400ADAB")]
	[FieldOffset(Offset = "0x8")]
	public uint checkpoint_id;

	[Token(Token = "0x400ADAC")]
	[FieldOffset(Offset = "0xC")]
	public uint level_id;

	[Token(Token = "0x400ADAD")]
	[FieldOffset(Offset = "0x10")]
	public string title_key;

	[Token(Token = "0x60081F7")]
	[Address(RVA = "0x30A3384", Offset = "0x30A3384", VA = "0x30A3384")]
	public HurricaneBLevelShow()
	{
	}
}
