using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000EB")]
public class EmotionRandomEffInfo
{
	[Token(Token = "0x40005D8")]
	[FieldOffset(Offset = "0x8")]
	public uint Idx;

	[Token(Token = "0x40005D9")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID ResID;

	[Token(Token = "0x6000607")]
	[Address(RVA = "0x2533430", Offset = "0x2533430", VA = "0x2533430")]
	public EmotionRandomEffInfo()
	{
	}
}
