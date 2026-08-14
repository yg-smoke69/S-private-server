using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20001E1")]
public class PatchOptionalResManagerData : CSVBaseData
{
	[Token(Token = "0x4000B41")]
	[FieldOffset(Offset = "0x8")]
	public uint OptionalReDefId;

	[Token(Token = "0x4000B42")]
	[FieldOffset(Offset = "0xC")]
	public bool IsDownload;

	[Token(Token = "0x4000B43")]
	[FieldOffset(Offset = "0xD")]
	public bool IsShow;

	[Token(Token = "0x4000B44")]
	[FieldOffset(Offset = "0x10")]
	public DateTime ShowTime;

	[Token(Token = "0x4000B45")]
	[FieldOffset(Offset = "0x20")]
	public DateTime EndTime;

	[Token(Token = "0x4000B46")]
	[FieldOffset(Offset = "0x30")]
	public bool HideInLogin;

	[Token(Token = "0x4000B47")]
	[FieldOffset(Offset = "0x31")]
	public bool HideAfterDownload;

	[Token(Token = "0x4000B48")]
	[FieldOffset(Offset = "0x32")]
	public bool IsDelete;

	[Token(Token = "0x4000B49")]
	[FieldOffset(Offset = "0x34")]
	public uint DownloadHardWare;

	[Token(Token = "0x4000B4A")]
	[FieldOffset(Offset = "0x38")]
	public uint AutoDownloadHardWare;

	[Token(Token = "0x4000B4B")]
	[FieldOffset(Offset = "0x3C")]
	public int DownloadSortId;

	[Token(Token = "0x4000B4C")]
	[FieldOffset(Offset = "0x40")]
	public uint GoPos;

	[Token(Token = "0x4000B4D")]
	[FieldOffset(Offset = "0x44")]
	public string SubGopos;

	[Token(Token = "0x4000B4E")]
	[FieldOffset(Offset = "0x48")]
	public bool ForceDownload;

	[Token(Token = "0x60009F1")]
	[Address(RVA = "0x2DBC8D8", Offset = "0x2DBC8D8", VA = "0x2DBC8D8")]
	public PatchOptionalResManagerData()
	{
	}

	[Token(Token = "0x60009F2")]
	[Address(RVA = "0x2DBC95C", Offset = "0x2DBC95C", VA = "0x2DBC95C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60009F3")]
	[Address(RVA = "0x2DBCDF0", Offset = "0x2DBCDF0", VA = "0x2DBCDF0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60009F4")]
	[Address(RVA = "0x2DBCE54", Offset = "0x2DBCE54", VA = "0x2DBCE54")]
	public PatchOptionalResManagerData ProduceNewPatchOptionalResManagerData(PatchOptionalResManagerUpdateDesc UpdateItem)
	{
		return null;
	}
}
