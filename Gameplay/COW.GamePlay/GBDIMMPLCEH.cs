using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x20004C2")]
internal class GBDIMMPLCEH : CSVBaseData, _Attribute
{
	[Token(Token = "0x20004C3")]
	public enum JPCILAOKNBJ
	{
		[Token(Token = "0x4003FC8")]
		LoadoutSubType_Campfire,
		[Token(Token = "0x4003FC9")]
		LoadoutSubType_Carepackage,
		[Token(Token = "0x4003FCA")]
		LoadoutSubType_Treasuremap,
		[Token(Token = "0x4003FCB")]
		LoadoutSubType_BountyContract,
		[Token(Token = "0x4003FCC")]
		LoadoutSubType_BountyScanner,
		[Token(Token = "0x4003FCD")]
		LoadoutSubType_PersonalUAV,
		[Token(Token = "0x4003FCE")]
		MAX
	}

	[Token(Token = "0x4003FBE")]
	[FieldOffset(Offset = "0x8")]
	public LGCOKIBHIJL BHOFCILPNJC;

	[Token(Token = "0x4003FBF")]
	[FieldOffset(Offset = "0xC")]
	public uint POBGKMDJMDC;

	[Token(Token = "0x4003FC0")]
	[FieldOffset(Offset = "0x10")]
	public JPCILAOKNBJ BGIFCCCLFPO;

	[Token(Token = "0x4003FC1")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID EBDNAJMAKHI;

	[Token(Token = "0x4003FC2")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID GDOGIGDHJJO;

	[Token(Token = "0x4003FC3")]
	[FieldOffset(Offset = "0x1C")]
	public bool FMFAEFPMBEF;

	[Token(Token = "0x4003FC4")]
	[FieldOffset(Offset = "0x20")]
	public int BIBCDMKIBNH;

	[Token(Token = "0x4003FC5")]
	[FieldOffset(Offset = "0x24")]
	public Dictionary<string, string> HOKGDJOFPFM;

	[Token(Token = "0x4003FC6")]
	[FieldOffset(Offset = "0x28")]
	public List<string> APKJHLONFOP;

	[Token(Token = "0x60018B9")]
	[Address(RVA = "0x1DAB3D0", Offset = "0x1DAB3D0", VA = "0x1DAB3D0")]
	public GBDIMMPLCEH()
	{
	}

	[Token(Token = "0x60018BA")]
	[Address(RVA = "0x1DAB4BC", Offset = "0x1DAB4BC", VA = "0x1DAB4BC", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60018BB")]
	[Address(RVA = "0x1DAB514", Offset = "0x1DAB514", VA = "0x1DAB514", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60018BC")]
	[Address(RVA = "0x1DAB578", Offset = "0x1DAB578", VA = "0x1DAB578", Slot = "4")]
	public override void ParseData(long HHLONFLCJBL, int KHCPMMPFLJC, string[] HBKMAMHJAIK, string[] LEDOBKGBDAJ)
	{
	}
}
