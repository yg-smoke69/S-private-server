using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B9E")]
public class ActionBlockDefine : ProcessBlockDefine
{
	[Token(Token = "0x600581D")]
	[Address(RVA = "0x379EBC8", Offset = "0x379EBC8", VA = "0x379EBC8")]
	public ActionBlockDefine()
	{
	}

	[Token(Token = "0x600581E")]
	[Address(RVA = "0x379EBD0", Offset = "0x379EBD0", VA = "0x379EBD0", Slot = "4")]
	public override bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x600581F")]
	[Address(RVA = "0x379EC5C", Offset = "0x379EC5C", VA = "0x379EC5C")]
	public new bool _003C_003EiFixBaseProxy_FromJsonData(BlockEditContext P0, JsonData P1)
	{
		return default(bool);
	}
}
