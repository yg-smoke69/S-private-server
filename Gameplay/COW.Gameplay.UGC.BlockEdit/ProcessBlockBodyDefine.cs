using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000BA0")]
public class ProcessBlockBodyDefine
{
	[Token(Token = "0x40061FA")]
	[FieldOffset(Offset = "0x8")]
	public List<BlockFieldDefine> fields;

	[Token(Token = "0x40061FB")]
	[FieldOffset(Offset = "0xC")]
	public bool isLinkable;

	[Token(Token = "0x40061FC")]
	[FieldOffset(Offset = "0x10")]
	public List<SerializeBlockFieldDefine> SerializeBlockFields;

	[Token(Token = "0x6005823")]
	[Address(RVA = "0x2F509E8", Offset = "0x2F509E8", VA = "0x2F509E8")]
	public ProcessBlockBodyDefine()
	{
	}

	[Token(Token = "0x6005824")]
	[Address(RVA = "0x2F509F8", Offset = "0x2F509F8", VA = "0x2F509F8")]
	public bool FromJsonData(BlockEditContext context, BlockDefine owner, JsonData jsonData, string blockName)
	{
		return default(bool);
	}
}
