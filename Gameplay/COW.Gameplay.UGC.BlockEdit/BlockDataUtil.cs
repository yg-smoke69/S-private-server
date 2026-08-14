using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000BA8")]
public static class BlockDataUtil
{
	[Token(Token = "0x4006223")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<string, string> CloneLocalVarDefineCache;

	[Token(Token = "0x4006224")]
	[FieldOffset(Offset = "0x4")]
	public static int ModifiedFuncParamIndex;

	[Token(Token = "0x4006225")]
	[FieldOffset(Offset = "0x8")]
	public static Dictionary<string, string> CheckLocalVarDefineRangeCache;

	[Token(Token = "0x4006226")]
	[FieldOffset(Offset = "0xC")]
	public static bool CheckLocalVarDefineRangeLogEnabled;

	[Token(Token = "0x4006227")]
	[FieldOffset(Offset = "0xD")]
	public static bool CheckLocalVarDefineRangeRepeated;

	[Token(Token = "0x4006228")]
	[FieldOffset(Offset = "0x10")]
	public static HashSet<string> CheckedBlocks;

	[Token(Token = "0x6005843")]
	[Address(RVA = "0x37ACE10", Offset = "0x37ACE10", VA = "0x37ACE10")]
	public static BlockData BuildBlockData(BlockEditContext context, JsonData jsonData)
	{
		return null;
	}

	[Token(Token = "0x6005844")]
	[Address(RVA = "0x37ACF0C", Offset = "0x37ACF0C", VA = "0x37ACF0C")]
	public static BlockData CreateBlockData(BlockEditContext context, string typeName)
	{
		return null;
	}

	[Token(Token = "0x6005845")]
	[Address(RVA = "0x37AD0A8", Offset = "0x37AD0A8", VA = "0x37AD0A8")]
	public static ValueData CreateSlotValueData(TypeInfo valueType, BlockData owner)
	{
		return null;
	}

	[Token(Token = "0x6005846")]
	[Address(RVA = "0x37AD1F4", Offset = "0x37AD1F4", VA = "0x37AD1F4")]
	public static LocalVarDefineData BuildLocalVarDefineData(BlockEditContext context, JsonData jsonData, BlockData owner)
	{
		return null;
	}

	[Token(Token = "0x6005847")]
	[Address(RVA = "0x37AD314", Offset = "0x37AD314", VA = "0x37AD314")]
	public static GraphVarDefineData CreateGraphVarDefineData(BlockEditContext context, GraphData owner, IOGCEGJJHLK varType, string varName)
	{
		return null;
	}

	[Token(Token = "0x6005848")]
	[Address(RVA = "0x37AD4FC", Offset = "0x37AD4FC", VA = "0x37AD4FC")]
	public static LocalVarDefineData CreateLocalVarDefineData(BlockEditContext context, GraphData graph, BlockData owner, string varName, TypeInfo typeInfo)
	{
		return null;
	}

	[Token(Token = "0x6005849")]
	[Address(RVA = "0x37AD6C4", Offset = "0x37AD6C4", VA = "0x37AD6C4")]
	public static bool WriteBlockData(BlockEditContext context, JsonWriter jsonWriter, BlockData item)
	{
		return default(bool);
	}

	[Token(Token = "0x600584A")]
	[Address(RVA = "0x37AD7A0", Offset = "0x37AD7A0", VA = "0x37AD7A0")]
	public static bool WriteBodyData(BlockEditContext context, JsonWriter jsonWriter, BodyData item)
	{
		return default(bool);
	}

	[Token(Token = "0x600584B")]
	[Address(RVA = "0x37AD880", Offset = "0x37AD880", VA = "0x37AD880")]
	public static bool WriteValueData(BlockEditContext context, JsonWriter jsonWriter, ValueData item)
	{
		return default(bool);
	}

	[Token(Token = "0x600584C")]
	[Address(RVA = "0x37AD95C", Offset = "0x37AD95C", VA = "0x37AD95C")]
	public static ValueData CreateConstDefaultValueByType(TypeInfo valueType)
	{
		return null;
	}

	[Token(Token = "0x600584D")]
	[Address(RVA = "0x37ADBA8", Offset = "0x37ADBA8", VA = "0x37ADBA8")]
	public static void CollectVarRefBlockRecords(VarRecord source, List<BlockRecord> blockRecords)
	{
	}
}
