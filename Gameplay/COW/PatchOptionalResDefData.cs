using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001D3")]
public class PatchOptionalResDefData : CSVBaseData
{
	[Token(Token = "0x4000B1D")]
	[FieldOffset(Offset = "0x8")]
	public uint OptionalReDefId;

	[Token(Token = "0x4000B1E")]
	[FieldOffset(Offset = "0xC")]
	public uint SortId;

	[Token(Token = "0x4000B1F")]
	[FieldOffset(Offset = "0x10")]
	public ResDownloadType DownloadOptionalType;

	[Token(Token = "0x4000B20")]
	[FieldOffset(Offset = "0x14")]
	public string[] ab_PathList;

	[Token(Token = "0x4000B21")]
	[FieldOffset(Offset = "0x18")]
	public EDownloadFileType fileType;

	[Token(Token = "0x60009C5")]
	[Address(RVA = "0x28D3028", Offset = "0x28D3028", VA = "0x28D3028")]
	public PatchOptionalResDefData()
	{
	}

	[Token(Token = "0x60009C6")]
	[Address(RVA = "0x28D30AC", Offset = "0x28D30AC", VA = "0x28D30AC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x28D3110", Offset = "0x28D3110", VA = "0x28D3110", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
