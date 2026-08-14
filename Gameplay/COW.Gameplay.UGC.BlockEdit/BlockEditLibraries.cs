using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000BA3")]
public class BlockEditLibraries
{
	[Token(Token = "0x4006202")]
	[FieldOffset(Offset = "0x8")]
	public readonly Dictionary<int, LibraryData> LibraryDict;

	[Token(Token = "0x6005834")]
	[Address(RVA = "0x37AFD04", Offset = "0x37AFD04", VA = "0x37AFD04")]
	public BlockEditLibraries()
	{
	}

	[Token(Token = "0x6005835")]
	[Address(RVA = "0x37B2544", Offset = "0x37B2544", VA = "0x37B2544")]
	public bool FromJsonData(BlockEditContext context, List<JsonData> jsonDatas)
	{
		return default(bool);
	}
}
