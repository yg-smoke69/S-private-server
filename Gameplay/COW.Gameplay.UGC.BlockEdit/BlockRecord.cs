using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B7D")]
public class BlockRecord
{
	[Token(Token = "0x400615D")]
	[FieldOffset(Offset = "0x8")]
	public BlockData Target;

	[Token(Token = "0x400615E")]
	[FieldOffset(Offset = "0xC")]
	public IBlockDataContainer Parent;

	[Token(Token = "0x400615F")]
	[FieldOffset(Offset = "0x10")]
	public int Index;

	[Token(Token = "0x4006160")]
	[FieldOffset(Offset = "0x14")]
	public bool InCurrentGraph;

	[Token(Token = "0x6005727")]
	[Address(RVA = "0x37BBE8C", Offset = "0x37BBE8C", VA = "0x37BBE8C")]
	public BlockRecord()
	{
	}

	[Token(Token = "0x6005728")]
	[Address(RVA = "0x37BBE9C", Offset = "0x37BBE9C", VA = "0x37BBE9C")]
	public void Reset()
	{
	}
}
