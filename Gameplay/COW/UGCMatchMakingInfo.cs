using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003158")]
public class UGCMatchMakingInfo
{
	[Token(Token = "0x4012BBA")]
	[FieldOffset(Offset = "0x8")]
	public bool IsRandomMatch;

	[Token(Token = "0x4012BBB")]
	[FieldOffset(Offset = "0xC")]
	public SceneEditSlotInfo CertainMapInfo;

	[Token(Token = "0x4012BBC")]
	[FieldOffset(Offset = "0x10")]
	public UGCRandomMatchMakingInfo RandomMapInfo;

	[Token(Token = "0x6014AD4")]
	[Address(RVA = "0x29F2B58", Offset = "0x29F2B58", VA = "0x29F2B58")]
	public UGCMatchMakingInfo()
	{
	}
}
