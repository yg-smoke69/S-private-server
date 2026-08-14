using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B90")]
public class LocalVarDefineData : VarDefineData
{
	[Token(Token = "0x40061D6")]
	[FieldOffset(Offset = "0x3C")]
	public BlockData Owner;

	[Token(Token = "0x60057E9")]
	[Address(RVA = "0x2F4E088", Offset = "0x2F4E088", VA = "0x2F4E088")]
	public LocalVarDefineData()
	{
	}

	[Token(Token = "0x60057EA")]
	[Address(RVA = "0x2F4E090", Offset = "0x2F4E090", VA = "0x2F4E090", Slot = "8")]
	public override bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x60057EB")]
	[Address(RVA = "0x2F4E3C0", Offset = "0x2F4E3C0", VA = "0x2F4E3C0", Slot = "9")]
	public override bool ToJsonData(BlockEditContext context, JsonWriter jsonWriter)
	{
		return default(bool);
	}

	[Token(Token = "0x60057EC")]
	[Address(RVA = "0x2F4E448", Offset = "0x2F4E448", VA = "0x2F4E448")]
	public LocalVarDefineData Clone(BlockData owner, GraphData graphData)
	{
		return null;
	}

	[Token(Token = "0x60057ED")]
	[Address(RVA = "0x2F4E344", Offset = "0x2F4E344", VA = "0x2F4E344")]
	public bool UpdateGetterAndSetter()
	{
		return default(bool);
	}

	[Token(Token = "0x60057EE")]
	[Address(RVA = "0x2F4E784", Offset = "0x2F4E784", VA = "0x2F4E784")]
	public BlockData FindProcessOwner()
	{
		return null;
	}

	[Token(Token = "0x60057EF")]
	[Address(RVA = "0x2F4EA1C", Offset = "0x2F4EA1C", VA = "0x2F4EA1C")]
	public bool _003C_003EiFixBaseProxy_FromJsonData(BlockEditContext P0, JsonData P1)
	{
		return default(bool);
	}

	[Token(Token = "0x60057F0")]
	[Address(RVA = "0x2F4EA20", Offset = "0x2F4EA20", VA = "0x2F4EA20")]
	public bool _003C_003EiFixBaseProxy_ToJsonData(BlockEditContext P0, JsonWriter P1)
	{
		return default(bool);
	}
}
