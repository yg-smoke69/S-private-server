using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B7E")]
public class BlockMoveRecord
{
	[Token(Token = "0x4006161")]
	[FieldOffset(Offset = "0x8")]
	public BlockData Target;

	[Token(Token = "0x4006162")]
	[FieldOffset(Offset = "0xC")]
	public IBlockDataContainer OriginalParent;

	[Token(Token = "0x4006163")]
	[FieldOffset(Offset = "0x10")]
	public int OriginalIndex;

	[Token(Token = "0x4006164")]
	[FieldOffset(Offset = "0x14")]
	public IBlockDataContainer TargetParent;

	[Token(Token = "0x4006165")]
	[FieldOffset(Offset = "0x18")]
	public int TargetIndex;

	[Token(Token = "0x6005729")]
	[Address(RVA = "0x37BB918", Offset = "0x37BB918", VA = "0x37BB918")]
	public BlockMoveRecord()
	{
	}

	[Token(Token = "0x600572A")]
	[Address(RVA = "0x37BB920", Offset = "0x37BB920", VA = "0x37BB920")]
	public void Remove()
	{
	}

	[Token(Token = "0x600572B")]
	[Address(RVA = "0x37BBA54", Offset = "0x37BBA54", VA = "0x37BBA54")]
	public void Add()
	{
	}

	[Token(Token = "0x600572C")]
	[Address(RVA = "0x37BBBA0", Offset = "0x37BBBA0", VA = "0x37BBBA0")]
	public void UndoRemove()
	{
	}

	[Token(Token = "0x600572D")]
	[Address(RVA = "0x37BBCEC", Offset = "0x37BBCEC", VA = "0x37BBCEC")]
	public void UndoAdd()
	{
	}

	[Token(Token = "0x600572E")]
	[Address(RVA = "0x37BBE20", Offset = "0x37BBE20", VA = "0x37BBE20")]
	public void Reset()
	{
	}
}
