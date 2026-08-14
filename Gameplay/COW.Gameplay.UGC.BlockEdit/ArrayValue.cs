using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B8B")]
public class ArrayValue
{
	[Token(Token = "0x40061AD")]
	[FieldOffset(Offset = "0x8")]
	public IOGCEGJJHLK arrayType;

	[Token(Token = "0x40061AE")]
	[FieldOffset(Offset = "0xC")]
	public List<ValueData> contents;

	[Token(Token = "0x60057B1")]
	[Address(RVA = "0x379EC64", Offset = "0x379EC64", VA = "0x379EC64")]
	public ArrayValue()
	{
	}

	[Token(Token = "0x60057B2")]
	[Address(RVA = "0x379EC74", Offset = "0x379EC74", VA = "0x379EC74")]
	public bool FromJsonData(BlockEditContext context, JsonData jsonData, BlockData owner)
	{
		return default(bool);
	}

	[Token(Token = "0x60057B3")]
	[Address(RVA = "0x379F050", Offset = "0x379F050", VA = "0x379F050")]
	public bool ToJsonData(BlockEditContext context, JsonWriter jsonWriter)
	{
		return default(bool);
	}

	[Token(Token = "0x60057B4")]
	[Address(RVA = "0x379F2B8", Offset = "0x379F2B8", VA = "0x379F2B8")]
	public ArrayValue Clone(BlockData owner, GraphData graphData)
	{
		return null;
	}

	[Token(Token = "0x60057B5")]
	[Address(RVA = "0x379F4D4", Offset = "0x379F4D4", VA = "0x379F4D4")]
	public bool ToExportProtoData(BlockEditContext context, List<EGKJIDMCGML> target)
	{
		return default(bool);
	}

	[Token(Token = "0x60057B6")]
	[Address(RVA = "0x379F658", Offset = "0x379F658", VA = "0x379F658")]
	public ValueData CreateAndAddItem(TypeInfo valueType)
	{
		return null;
	}

	[Token(Token = "0x60057B7")]
	[Address(RVA = "0x379F7DC", Offset = "0x379F7DC", VA = "0x379F7DC")]
	public bool RemoveItem(ValueData item)
	{
		return default(bool);
	}
}
