using Il2CppDummyDll;
using WwiseGameSyncs;

namespace GCommon;

[Token(Token = "0x2003E59")]
public class Wwise_RTPC_Object
{
	[Token(Token = "0x401A5CF")]
	[FieldOffset(Offset = "0x8")]
	public WwiseGameSyncID RTPC_ID;

	[Token(Token = "0x401A5D0")]
	[FieldOffset(Offset = "0xC")]
	public float Value;

	[Token(Token = "0x6019588")]
	[Address(RVA = "0x2BDC4F4", Offset = "0x2BDC4F4", VA = "0x2BDC4F4")]
	public Wwise_RTPC_Object()
	{
	}
}
