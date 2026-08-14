using Il2CppDummyDll;
using LitJson;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B91")]
public class GraphVarDefineData : VarDefineData
{
	[Token(Token = "0x40061D7")]
	[FieldOffset(Offset = "0x3C")]
	public GraphData Owner;

	[Token(Token = "0x40061D8")]
	[FieldOffset(Offset = "0x40")]
	public int index;

	[Token(Token = "0x40061D9")]
	[FieldOffset(Offset = "0x44")]
	public BlockData GlobalGetterData;

	[Token(Token = "0x40061DA")]
	[FieldOffset(Offset = "0x48")]
	public BlockData GlobalSetterData;

	[Token(Token = "0x60057F1")]
	[Address(RVA = "0x2F449F4", Offset = "0x2F449F4", VA = "0x2F449F4")]
	public GraphVarDefineData()
	{
	}

	[Token(Token = "0x60057F2")]
	[Address(RVA = "0x2F48D78", Offset = "0x2F48D78", VA = "0x2F48D78", Slot = "8")]
	public override bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x60057F3")]
	[Address(RVA = "0x2F456DC", Offset = "0x2F456DC", VA = "0x2F456DC")]
	public PHNKMMPPPOI ToExportProtoData(BlockEditContext context)
	{
		return null;
	}

	[Token(Token = "0x60057F4")]
	[Address(RVA = "0x2F49710", Offset = "0x2F49710", VA = "0x2F49710")]
	public bool BuildGetterAndSetter(BlockEditContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x60057F5")]
	[Address(RVA = "0x2F49934", Offset = "0x2F49934", VA = "0x2F49934")]
	public bool UpdateGetterAndSetter()
	{
		return default(bool);
	}

	[Token(Token = "0x60057F6")]
	[Address(RVA = "0x2F49634", Offset = "0x2F49634", VA = "0x2F49634")]
	public void InitDefaultValue()
	{
	}

	[Token(Token = "0x60057F7")]
	[Address(RVA = "0x2F49F08", Offset = "0x2F49F08", VA = "0x2F49F08", Slot = "9")]
	public override bool ToJsonData(BlockEditContext context, JsonWriter jsonWriter)
	{
		return default(bool);
	}

	[Token(Token = "0x60057F8")]
	[Address(RVA = "0x2F4A2FC", Offset = "0x2F4A2FC", VA = "0x2F4A2FC")]
	public bool _003C_003EiFixBaseProxy_FromJsonData(BlockEditContext P0, JsonData P1)
	{
		return default(bool);
	}

	[Token(Token = "0x60057F9")]
	[Address(RVA = "0x2F4A300", Offset = "0x2F4A300", VA = "0x2F4A300")]
	public bool _003C_003EiFixBaseProxy_ToJsonData(BlockEditContext P0, JsonWriter P1)
	{
		return default(bool);
	}
}
