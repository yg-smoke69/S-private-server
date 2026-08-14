using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B82")]
public class FuncDefineRecord
{
	[Token(Token = "0x4006181")]
	[FieldOffset(Offset = "0x8")]
	public FuncDefineData DefineData;

	[Token(Token = "0x4006182")]
	[FieldOffset(Offset = "0xC")]
	public readonly List<BlockRecord> Callers;

	[Token(Token = "0x6005757")]
	[Address(RVA = "0x37C1C98", Offset = "0x37C1C98", VA = "0x37C1C98")]
	public FuncDefineRecord()
	{
	}

	[Token(Token = "0x6005758")]
	[Address(RVA = "0x37C1D24", Offset = "0x37C1D24", VA = "0x37C1D24")]
	public void Reset()
	{
	}
}
