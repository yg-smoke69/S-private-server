using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001880")]
public class BattleTagCount
{
	[Token(Token = "0x4009D17")]
	[FieldOffset(Offset = "0x8")]
	public uint tag_id;

	[Token(Token = "0x4009D18")]
	[FieldOffset(Offset = "0xC")]
	public uint count;

	[Token(Token = "0x6007ED9")]
	[Address(RVA = "0x317BA80", Offset = "0x317BA80", VA = "0x317BA80")]
	public BattleTagCount()
	{
	}
}
