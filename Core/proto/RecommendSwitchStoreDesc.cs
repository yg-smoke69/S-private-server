using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AC6")]
public class RecommendSwitchStoreDesc
{
	[Token(Token = "0x400A897")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A898")]
	[FieldOffset(Offset = "0xC")]
	public bool is_open_recommend;

	[Token(Token = "0x6008123")]
	[Address(RVA = "0x33E1210", Offset = "0x33E1210", VA = "0x33E1210")]
	public RecommendSwitchStoreDesc()
	{
	}
}
