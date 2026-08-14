using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B93")]
public class GraphVarRecord
{
	[Token(Token = "0x40061DD")]
	[FieldOffset(Offset = "0x8")]
	public VarRecord Record;

	[Token(Token = "0x40061DE")]
	[FieldOffset(Offset = "0xC")]
	public int Index;

	[Token(Token = "0x60057FD")]
	[Address(RVA = "0x2F4A304", Offset = "0x2F4A304", VA = "0x2F4A304")]
	public GraphVarRecord()
	{
	}

	[Token(Token = "0x60057FE")]
	[Address(RVA = "0x2F4A408", Offset = "0x2F4A408", VA = "0x2F4A408")]
	public void Reset()
	{
	}
}
