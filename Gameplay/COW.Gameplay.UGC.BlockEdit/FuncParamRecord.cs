using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B81")]
public class FuncParamRecord
{
	[Token(Token = "0x400617A")]
	[FieldOffset(Offset = "0x8")]
	internal bool IsExecuted;

	[Token(Token = "0x400617B")]
	[FieldOffset(Offset = "0xC")]
	public FuncDefineData DefineData;

	[Token(Token = "0x400617C")]
	[FieldOffset(Offset = "0x10")]
	public VarRecord ParamDefineRecord;

	[Token(Token = "0x400617D")]
	[FieldOffset(Offset = "0x14")]
	public int Index;

	[Token(Token = "0x400617E")]
	[FieldOffset(Offset = "0x18")]
	public readonly List<BlockData> Callers;

	[Token(Token = "0x400617F")]
	[FieldOffset(Offset = "0x1C")]
	public readonly List<ValueData> ParamSlots;

	[Token(Token = "0x4006180")]
	[FieldOffset(Offset = "0x20")]
	public readonly List<BlockRecord> DataBlocksInParamSlot;

	[Token(Token = "0x6005755")]
	[Address(RVA = "0x37C1E64", Offset = "0x37C1E64", VA = "0x37C1E64")]
	public FuncParamRecord()
	{
	}

	[Token(Token = "0x6005756")]
	[Address(RVA = "0x37C1F7C", Offset = "0x37C1F7C", VA = "0x37C1F7C")]
	public void Reset()
	{
	}
}
