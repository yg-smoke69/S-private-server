using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B9F")]
public class FunctionBlockDefine : ProcessBlockDefine
{
	[Token(Token = "0x6005820")]
	[Address(RVA = "0x2F434A0", Offset = "0x2F434A0", VA = "0x2F434A0")]
	public FunctionBlockDefine()
	{
	}

	[Token(Token = "0x6005821")]
	[Address(RVA = "0x2F43530", Offset = "0x2F43530", VA = "0x2F43530", Slot = "4")]
	public override bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005822")]
	[Address(RVA = "0x2F43ACC", Offset = "0x2F43ACC", VA = "0x2F43ACC")]
	public new bool _003C_003EiFixBaseProxy_FromJsonData(BlockEditContext P0, JsonData P1)
	{
		return default(bool);
	}
}
