using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B9A")]
public class VarRefFieldDefine : SerializeBlockFieldDefine
{
	[Token(Token = "0x6005811")]
	[Address(RVA = "0x2F556DC", Offset = "0x2F556DC", VA = "0x2F556DC")]
	public VarRefFieldDefine()
	{
	}

	[Token(Token = "0x6005812")]
	[Address(RVA = "0x2F556E4", Offset = "0x2F556E4", VA = "0x2F556E4", Slot = "4")]
	public override bool FromJsonData(BlockEditContext context, BlockDefine owner, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005813")]
	[Address(RVA = "0x2F5577C", Offset = "0x2F5577C", VA = "0x2F5577C")]
	public new bool _003C_003EiFixBaseProxy_FromJsonData(BlockEditContext P0, BlockDefine P1, JsonData P2)
	{
		return default(bool);
	}
}
