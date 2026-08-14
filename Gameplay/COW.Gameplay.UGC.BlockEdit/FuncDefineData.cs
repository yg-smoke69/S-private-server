using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B80")]
public class FuncDefineData
{
	[Token(Token = "0x400616F")]
	[FieldOffset(Offset = "0x8")]
	public string id;

	[Token(Token = "0x4006170")]
	[FieldOffset(Offset = "0xC")]
	protected string funcName;

	[Token(Token = "0x4006171")]
	[FieldOffset(Offset = "0x10")]
	public bool ReturnTypeExisted;

	[Token(Token = "0x4006172")]
	[FieldOffset(Offset = "0x14")]
	protected TypeInfo returnType;

	[Token(Token = "0x4006173")]
	[FieldOffset(Offset = "0x1C")]
	public List<LocalVarDefineData> paramDefines;

	[Token(Token = "0x4006174")]
	[FieldOffset(Offset = "0x20")]
	public string DefinerId;

	[Token(Token = "0x4006175")]
	[FieldOffset(Offset = "0x24")]
	public BlockData CallerData;

	[Token(Token = "0x4006176")]
	[FieldOffset(Offset = "0x28")]
	public Action OnChanged;

	[Token(Token = "0x4006177")]
	[FieldOffset(Offset = "0x2C")]
	public Action OnRemoved;

	[Token(Token = "0x4006178")]
	[FieldOffset(Offset = "0x30")]
	public BlockEditContext Context;

	[Token(Token = "0x4006179")]
	[FieldOffset(Offset = "0x34")]
	public GraphData Graph;

	[Token(Token = "0x170006F9")]
	public string FuncName
	{
		[Token(Token = "0x6005746")]
		[Address(RVA = "0x37BF290", Offset = "0x37BF290", VA = "0x37BF290")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005747")]
		[Address(RVA = "0x37BF2E8", Offset = "0x37BF2E8", VA = "0x37BF2E8")]
		set
		{
		}
	}

	[Token(Token = "0x170006FA")]
	public TypeInfo ReturnType
	{
		[Token(Token = "0x6005748")]
		[Address(RVA = "0x37A9540", Offset = "0x37A9540", VA = "0x37A9540")]
		get
		{
			return default(TypeInfo);
		}
		[Token(Token = "0x6005749")]
		[Address(RVA = "0x37BF3E8", Offset = "0x37BF3E8", VA = "0x37BF3E8")]
		set
		{
		}
	}

	[Token(Token = "0x170006FB")]
	public BlockData DefinerData
	{
		[Token(Token = "0x600574A")]
		[Address(RVA = "0x37BF6DC", Offset = "0x37BF6DC", VA = "0x37BF6DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005745")]
	[Address(RVA = "0x37BF204", Offset = "0x37BF204", VA = "0x37BF204")]
	public FuncDefineData()
	{
	}

	[Token(Token = "0x600574B")]
	[Address(RVA = "0x37BF820", Offset = "0x37BF820", VA = "0x37BF820")]
	public bool FromJsonData(BlockEditContext context, JsonData jsonData, BlockData owner)
	{
		return default(bool);
	}

	[Token(Token = "0x600574C")]
	[Address(RVA = "0x37BFF08", Offset = "0x37BFF08", VA = "0x37BFF08")]
	public bool ToJsonData(BlockEditContext context, JsonWriter jsonWriter)
	{
		return default(bool);
	}

	[Token(Token = "0x600574D")]
	[Address(RVA = "0x37C021C", Offset = "0x37C021C", VA = "0x37C021C")]
	public KDNPLMHKBHC ToExportProtoData(BlockEditContext context)
	{
		return null;
	}

	[Token(Token = "0x600574E")]
	[Address(RVA = "0x37BFBE0", Offset = "0x37BFBE0", VA = "0x37BFBE0")]
	public bool CreateCaller(BlockEditContext context, BlockData definerData)
	{
		return default(bool);
	}

	[Token(Token = "0x600574F")]
	[Address(RVA = "0x37C043C", Offset = "0x37C043C", VA = "0x37C043C")]
	public FuncDefineData Clone(GraphData graph, BlockData definer)
	{
		return null;
	}

	[Token(Token = "0x6005750")]
	[Address(RVA = "0x37C06C0", Offset = "0x37C06C0", VA = "0x37C06C0")]
	public bool UpdateParamType(TypeInfo typeInfo, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6005751")]
	[Address(RVA = "0x37C0BD4", Offset = "0x37C0BD4", VA = "0x37C0BD4")]
	public void AddParamDefine(FuncParamRecord record)
	{
	}

	[Token(Token = "0x6005752")]
	[Address(RVA = "0x37C1380", Offset = "0x37C1380", VA = "0x37C1380")]
	public void AddParamDefine(LocalVarDefineData paramDefine, int index)
	{
	}

	[Token(Token = "0x6005753")]
	[Address(RVA = "0x37C14DC", Offset = "0x37C14DC", VA = "0x37C14DC")]
	public void RemoveParamDefine(FuncParamRecord record)
	{
	}

	[Token(Token = "0x6005754")]
	[Address(RVA = "0x37C1B84", Offset = "0x37C1B84", VA = "0x37C1B84")]
	public bool RemoveParamDefine(int index)
	{
		return default(bool);
	}
}
