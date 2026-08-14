using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B96")]
public class BlockFieldDefine
{
	[Token(Token = "0x40061E7")]
	[FieldOffset(Offset = "0x8")]
	public string fieldType;

	[Token(Token = "0x40061E8")]
	[FieldOffset(Offset = "0xC")]
	public string labelKey;

	[Token(Token = "0x40061E9")]
	[FieldOffset(Offset = "0x10")]
	public string enumType;

	[Token(Token = "0x40061EA")]
	[FieldOffset(Offset = "0x14")]
	public bool isNotLinkable;

	[Token(Token = "0x40061EB")]
	[FieldOffset(Offset = "0x15")]
	public bool updateBlock;

	[Token(Token = "0x40061EC")]
	[FieldOffset(Offset = "0x18")]
	public BlockDefine Owner;

	[Token(Token = "0x6005804")]
	[Address(RVA = "0x37AFA7C", Offset = "0x37AFA7C", VA = "0x37AFA7C")]
	public BlockFieldDefine()
	{
	}

	[Token(Token = "0x6005805")]
	[Address(RVA = "0x37BB698", Offset = "0x37BB698", VA = "0x37BB698", Slot = "4")]
	public virtual bool FromJsonData(BlockEditContext context, BlockDefine owner, JsonData jsonData)
	{
		return default(bool);
	}
}
