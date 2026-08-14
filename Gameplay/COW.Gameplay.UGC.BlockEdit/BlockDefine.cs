using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B94")]
public class BlockDefine
{
	[Token(Token = "0x40061DF")]
	[FieldOffset(Offset = "0x8")]
	public string blockType;

	[Token(Token = "0x40061E0")]
	[FieldOffset(Offset = "0xC")]
	public string typeName;

	[Token(Token = "0x40061E1")]
	[FieldOffset(Offset = "0x10")]
	public MACLCEBEDMO funcType;

	[Token(Token = "0x40061E2")]
	[FieldOffset(Offset = "0x14")]
	public string owner;

	[Token(Token = "0x40061E3")]
	[FieldOffset(Offset = "0x18")]
	public bool IsNotExportable;

	[Token(Token = "0x40061E4")]
	[FieldOffset(Offset = "0x1C")]
	public List<SerializeBlockFieldDefine> SerializeBlockFields;

	[Token(Token = "0x60057FF")]
	[Address(RVA = "0x37ADDFC", Offset = "0x37ADDFC", VA = "0x37ADDFC")]
	public BlockDefine()
	{
	}

	[Token(Token = "0x6005800")]
	[Address(RVA = "0x37ADE68", Offset = "0x37ADE68", VA = "0x37ADE68", Slot = "4")]
	public virtual bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}
}
