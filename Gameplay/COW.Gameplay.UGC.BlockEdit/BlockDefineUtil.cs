using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000BAD")]
public static class BlockDefineUtil
{
	[Token(Token = "0x400622D")]
	[FieldOffset(Offset = "0x0")]
	public static int CurrentBuildBodyIndex;

	[Token(Token = "0x400622E")]
	[FieldOffset(Offset = "0x4")]
	public static int CurrentBuildFieldIndex;

	[Token(Token = "0x400622F")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map7;

	[Token(Token = "0x6005862")]
	[Address(RVA = "0x37A0BE8", Offset = "0x37A0BE8", VA = "0x37A0BE8")]
	public static BlockDefine GetBlockDefine(BlockEditContext context, string typeName)
	{
		return null;
	}

	[Token(Token = "0x6005863")]
	[Address(RVA = "0x37AE750", Offset = "0x37AE750", VA = "0x37AE750")]
	public static BlockDefine BuildBlockDefine(BlockEditContext context, JsonData jsonData, string key, string defaultBlockType, bool allowEmpty = true)
	{
		return null;
	}

	[Token(Token = "0x6005864")]
	[Address(RVA = "0x37AEC9C", Offset = "0x37AEC9C", VA = "0x37AEC9C")]
	public static BlockFieldDefine BuildField(BlockEditContext context, BlockDefine owner, JsonData jsonData, string key, string blockName, bool allowEmpty = true)
	{
		return null;
	}
}
