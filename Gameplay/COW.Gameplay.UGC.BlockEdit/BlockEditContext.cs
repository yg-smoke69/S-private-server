using System.Collections.Generic;
using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B6F")]
public class BlockEditContext
{
	[Token(Token = "0x4006124")]
	[FieldOffset(Offset = "0x8")]
	public BlockDefineDictionary BlockDefine;

	[Token(Token = "0x4006125")]
	[FieldOffset(Offset = "0xC")]
	public BlockEditLibraries BlockLibraries;

	[Token(Token = "0x4006126")]
	[FieldOffset(Offset = "0x10")]
	public BlockEditGraphs BlockGraphs;

	[Token(Token = "0x4006127")]
	[FieldOffset(Offset = "0x14")]
	public GraphData CurrentBuildGraphData;

	[Token(Token = "0x4006128")]
	[FieldOffset(Offset = "0x18")]
	public GraphData CurrentExportGraphData;

	[Token(Token = "0x4006129")]
	[FieldOffset(Offset = "0x1C")]
	public List<JGIADJOKNHI> CurrentExportGraphs;

	[Token(Token = "0x400612A")]
	[FieldOffset(Offset = "0x20")]
	public EditorMiscData CurrentExportMiscData;

	[Token(Token = "0x400612B")]
	[FieldOffset(Offset = "0x24")]
	public GraphData CurrentEditGraphData;

	[Token(Token = "0x400612C")]
	[FieldOffset(Offset = "0x28")]
	public string CopyBlockId;

	[Token(Token = "0x400612D")]
	[FieldOffset(Offset = "0x2C")]
	public string CopyBlockOwnerGraphId;

	[Token(Token = "0x400612E")]
	[FieldOffset(Offset = "0x30")]
	public JGIADJOKNHI CurrentExportUGCGraphData;

	[Token(Token = "0x60056D0")]
	[Address(RVA = "0x37AFC14", Offset = "0x37AFC14", VA = "0x37AFC14")]
	public BlockEditContext()
	{
	}
}
