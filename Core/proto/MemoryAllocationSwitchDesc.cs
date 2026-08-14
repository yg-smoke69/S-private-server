using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B02")]
public class MemoryAllocationSwitchDesc
{
	[Token(Token = "0x400A9E1")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A9E2")]
	[FieldOffset(Offset = "0xC")]
	public bool is_open;

	[Token(Token = "0x600815D")]
	[Address(RVA = "0x30A8820", Offset = "0x30A8820", VA = "0x30A8820")]
	public MemoryAllocationSwitchDesc()
	{
	}
}
