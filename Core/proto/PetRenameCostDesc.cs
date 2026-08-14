using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019C6")]
public class PetRenameCostDesc
{
	[Token(Token = "0x400A178")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A179")]
	[FieldOffset(Offset = "0xC")]
	public uint diamond_cost;

	[Token(Token = "0x600801E")]
	[Address(RVA = "0x33DF718", Offset = "0x33DF718", VA = "0x33DF718")]
	public PetRenameCostDesc()
	{
	}
}
