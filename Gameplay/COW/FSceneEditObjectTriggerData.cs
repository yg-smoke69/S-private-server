using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200321F")]
public class FSceneEditObjectTriggerData
{
	[Token(Token = "0x4013114")]
	[FieldOffset(Offset = "0x8")]
	public OMDNLEEOJBD TriggerType;

	[Token(Token = "0x4013115")]
	[FieldOffset(Offset = "0xC")]
	public bool IsShow;

	[Token(Token = "0x6015217")]
	[Address(RVA = "0xDE3390", Offset = "0xDE3390", VA = "0xDE3390")]
	public FSceneEditObjectTriggerData()
	{
	}
}
