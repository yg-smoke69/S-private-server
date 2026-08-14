using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200321B")]
public class FSceneEditObjectBuffData
{
	[Token(Token = "0x401310F")]
	[FieldOffset(Offset = "0x8")]
	public KFFPBFNDECE BuffType;

	[Token(Token = "0x4013110")]
	[FieldOffset(Offset = "0xC")]
	public int BuffTime;

	[Token(Token = "0x6015213")]
	[Address(RVA = "0xDE2FD0", Offset = "0xDE2FD0", VA = "0xDE2FD0")]
	public FSceneEditObjectBuffData()
	{
	}
}
