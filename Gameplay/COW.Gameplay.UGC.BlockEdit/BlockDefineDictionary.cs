using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B95")]
public class BlockDefineDictionary
{
	[Token(Token = "0x40061E5")]
	[FieldOffset(Offset = "0x8")]
	public bool IsDataCorrupted;

	[Token(Token = "0x40061E6")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<string, BlockDefine> BlockDefines;

	[Token(Token = "0x6005801")]
	[Address(RVA = "0x37AE1DC", Offset = "0x37AE1DC", VA = "0x37AE1DC")]
	public BlockDefineDictionary()
	{
	}

	[Token(Token = "0x6005802")]
	[Address(RVA = "0x37AE268", Offset = "0x37AE268", VA = "0x37AE268")]
	public void Clear()
	{
	}

	[Token(Token = "0x6005803")]
	[Address(RVA = "0x37AE328", Offset = "0x37AE328", VA = "0x37AE328")]
	public bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}
}
