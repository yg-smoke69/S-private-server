using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B9C")]
public abstract class ProcessBlockDefine : BlockDefine
{
	[Token(Token = "0x40061F8")]
	[FieldOffset(Offset = "0x20")]
	public List<ProcessBlockBodyDefine> bodies;

	[Token(Token = "0x6005817")]
	[Address(RVA = "0x2F434A4", Offset = "0x2F434A4", VA = "0x2F434A4")]
	protected ProcessBlockDefine()
	{
	}

	[Token(Token = "0x6005818")]
	[Address(RVA = "0x2F435B8", Offset = "0x2F435B8", VA = "0x2F435B8", Slot = "4")]
	public override bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005819")]
	[Address(RVA = "0x2F50C14", Offset = "0x2F50C14", VA = "0x2F50C14")]
	public bool _003C_003EiFixBaseProxy_FromJsonData(BlockEditContext P0, JsonData P1)
	{
		return default(bool);
	}
}
