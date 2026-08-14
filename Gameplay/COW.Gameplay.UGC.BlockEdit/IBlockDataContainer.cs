using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000BA7")]
public interface IBlockDataContainer
{
	[Token(Token = "0x600583C")]
	BlockData GetOwner();

	[Token(Token = "0x600583D")]
	BlockData GetChild(int index);

	[Token(Token = "0x600583E")]
	int GetChildIndex(BlockData blockData);

	[Token(Token = "0x600583F")]
	bool AddBlockData(BlockData blockData, int index, bool doRegistering);

	[Token(Token = "0x6005840")]
	bool RemoveBlockData(BlockData blockData, bool doUnregistering);

	[Token(Token = "0x6005841")]
	bool AddBlockData(BlockRecord record);

	[Token(Token = "0x6005842")]
	bool RemoveBlockData(BlockRecord record);
}
