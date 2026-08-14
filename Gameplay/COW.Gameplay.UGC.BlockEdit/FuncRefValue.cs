using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B8C")]
public class FuncRefValue
{
	[Token(Token = "0x40061AF")]
	[FieldOffset(Offset = "0x8")]
	public string graphId;

	[Token(Token = "0x40061B0")]
	[FieldOffset(Offset = "0xC")]
	public string funcId;

	[Token(Token = "0x40061B1")]
	[FieldOffset(Offset = "0x10")]
	public bool isAsync;

	[Token(Token = "0x40061B2")]
	[FieldOffset(Offset = "0x14")]
	public List<ValueData> args;

	[Token(Token = "0x60057B8")]
	[Address(RVA = "0x2F40884", Offset = "0x2F40884", VA = "0x2F40884")]
	public FuncRefValue()
	{
	}

	[Token(Token = "0x60057B9")]
	[Address(RVA = "0x2F40910", Offset = "0x2F40910", VA = "0x2F40910")]
	public bool FromJsonData(BlockEditContext context, JsonData jsonData, BlockData owner)
	{
		return default(bool);
	}

	[Token(Token = "0x60057BA")]
	[Address(RVA = "0x2F415B4", Offset = "0x2F415B4", VA = "0x2F415B4")]
	public bool ToJsonData(BlockEditContext context, JsonWriter jsonWriter)
	{
		return default(bool);
	}

	[Token(Token = "0x60057BB")]
	[Address(RVA = "0x2F42C28", Offset = "0x2F42C28", VA = "0x2F42C28")]
	public FuncRefValue Clone(BlockData owner, GraphData graphData)
	{
		return null;
	}

	[Token(Token = "0x60057BC")]
	[Address(RVA = "0x2F43138", Offset = "0x2F43138", VA = "0x2F43138")]
	public void AddItem(ValueData valueData, int index)
	{
	}

	[Token(Token = "0x60057BD")]
	[Address(RVA = "0x2F432EC", Offset = "0x2F432EC", VA = "0x2F432EC")]
	public bool RemoveItem(int index)
	{
		return default(bool);
	}
}
