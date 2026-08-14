using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B9B")]
public class DataBlockDefine : BlockDefine
{
	[Token(Token = "0x40061F5")]
	[FieldOffset(Offset = "0x20")]
	public TypeInfo ReturnType;

	[Token(Token = "0x40061F6")]
	[FieldOffset(Offset = "0x28")]
	public List<BlockFieldDefine> fields;

	[Token(Token = "0x40061F7")]
	[FieldOffset(Offset = "0x2C")]
	public int UIBlockType;

	[Token(Token = "0x6005814")]
	[Address(RVA = "0x37AEC98", Offset = "0x37AEC98", VA = "0x37AEC98")]
	public DataBlockDefine()
	{
	}

	[Token(Token = "0x6005815")]
	[Address(RVA = "0x37BDB68", Offset = "0x37BDB68", VA = "0x37BDB68", Slot = "4")]
	public override bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005816")]
	[Address(RVA = "0x37BDE34", Offset = "0x37BDE34", VA = "0x37BDE34")]
	public bool _003C_003EiFixBaseProxy_FromJsonData(BlockEditContext P0, JsonData P1)
	{
		return default(bool);
	}
}
