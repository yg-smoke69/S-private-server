using Il2CppDummyDll;

namespace WwiseGameSyncs;

[Token(Token = "0x20002A9")]
public class GroupBase
{
	[Token(Token = "0x4003287")]
	[FieldOffset(Offset = "0x8")]
	public WwiseGameSyncID Value;

	[Token(Token = "0x4003288")]
	[FieldOffset(Offset = "0xC")]
	public WwiseGameSyncID GroupID;

	[Token(Token = "0x6000D2A")]
	[Address(RVA = "0x336DA2C", Offset = "0x336DA2C", VA = "0x336DA2C")]
	public GroupBase()
	{
	}
}
