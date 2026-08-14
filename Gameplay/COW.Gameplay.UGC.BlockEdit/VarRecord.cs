using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B92")]
public class VarRecord
{
	[Token(Token = "0x40061DB")]
	[FieldOffset(Offset = "0x8")]
	public VarDefineData VarDefine;

	[Token(Token = "0x40061DC")]
	[FieldOffset(Offset = "0xC")]
	public readonly List<BlockRecord> RefBlockRecords;

	[Token(Token = "0x60057FA")]
	[Address(RVA = "0x2F4A37C", Offset = "0x2F4A37C", VA = "0x2F4A37C")]
	public VarRecord()
	{
	}

	[Token(Token = "0x60057FB")]
	[Address(RVA = "0x2F55530", Offset = "0x2F55530", VA = "0x2F55530")]
	public void CollectRefBlocks()
	{
	}

	[Token(Token = "0x60057FC")]
	[Address(RVA = "0x2F4A484", Offset = "0x2F4A484", VA = "0x2F4A484")]
	public void Reset()
	{
	}
}
