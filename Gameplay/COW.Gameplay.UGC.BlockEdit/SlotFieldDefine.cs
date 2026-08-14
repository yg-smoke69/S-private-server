using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B98")]
public class SlotFieldDefine : SerializeBlockFieldDefine
{
	[Token(Token = "0x40061F3")]
	[FieldOffset(Offset = "0x38")]
	public bool notAllowNull;

	[Token(Token = "0x600580B")]
	[Address(RVA = "0x2F50F50", Offset = "0x2F50F50", VA = "0x2F50F50")]
	public SlotFieldDefine()
	{
	}

	[Token(Token = "0x600580C")]
	[Address(RVA = "0x2F50F58", Offset = "0x2F50F58", VA = "0x2F50F58", Slot = "4")]
	public override bool FromJsonData(BlockEditContext context, BlockDefine owner, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x600580D")]
	[Address(RVA = "0x2F51088", Offset = "0x2F51088", VA = "0x2F51088")]
	public new bool _003C_003EiFixBaseProxy_FromJsonData(BlockEditContext P0, BlockDefine P1, JsonData P2)
	{
		return default(bool);
	}
}
