using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B99")]
public class LocalVarDefineFieldDefine : SerializeBlockFieldDefine
{
	[Token(Token = "0x40061F4")]
	[FieldOffset(Offset = "0x38")]
	public bool isOut;

	[Token(Token = "0x600580E")]
	[Address(RVA = "0x2F4EA24", Offset = "0x2F4EA24", VA = "0x2F4EA24")]
	public LocalVarDefineFieldDefine()
	{
	}

	[Token(Token = "0x600580F")]
	[Address(RVA = "0x2F4EA34", Offset = "0x2F4EA34", VA = "0x2F4EA34", Slot = "4")]
	public override bool FromJsonData(BlockEditContext context, BlockDefine owner, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005810")]
	[Address(RVA = "0x2F4EDDC", Offset = "0x2F4EDDC", VA = "0x2F4EDDC")]
	public new bool _003C_003EiFixBaseProxy_FromJsonData(BlockEditContext P0, BlockDefine P1, JsonData P2)
	{
		return default(bool);
	}
}
