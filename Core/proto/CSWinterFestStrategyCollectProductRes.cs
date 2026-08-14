using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200185A")]
public class CSWinterFestStrategyCollectProductRes
{
	[Token(Token = "0x4009CD6")]
	[FieldOffset(Offset = "0x8")]
	public MiniGameItem products;

	[Token(Token = "0x4009CD7")]
	[FieldOffset(Offset = "0xC")]
	public uint last_update_at;

	[Token(Token = "0x6007EB3")]
	[Address(RVA = "0x309AAB0", Offset = "0x309AAB0", VA = "0x309AAB0")]
	public CSWinterFestStrategyCollectProductRes()
	{
	}
}
