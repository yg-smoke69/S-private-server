using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using WwiseGameSyncs;

namespace COW.GamePlay;

[Token(Token = "0x2000731")]
public class CDPEGEHFLFO : CSVBaseData
{
	[Token(Token = "0x4004C9C")]
	[FieldOffset(Offset = "0x8")]
	public int POBGKMDJMDC;

	[Token(Token = "0x4004C9D")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, ResourceID> CJPDAKCNJBO;

	[Token(Token = "0x4004C9E")]
	[FieldOffset(Offset = "0x10")]
	public WwiseGameSyncID GDEMFFOAEOK;

	[Token(Token = "0x6002D8E")]
	[Address(RVA = "0x13C510C", Offset = "0x13C510C", VA = "0x13C510C")]
	public CDPEGEHFLFO()
	{
	}

	[Token(Token = "0x6002D8F")]
	[Address(RVA = "0x13C51C4", Offset = "0x13C51C4", VA = "0x13C51C4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6002D90")]
	[Address(RVA = "0x13C5228", Offset = "0x13C5228", VA = "0x13C5228", Slot = "4")]
	public override void ParseData(long HHLONFLCJBL, int KHCPMMPFLJC, string[] HBKMAMHJAIK, string[] LEDOBKGBDAJ)
	{
	}

	[Token(Token = "0x6002D91")]
	[Address(RVA = "0x13C5754", Offset = "0x13C5754", VA = "0x13C5754")]
	public ResourceID MIAGNCFFGKH(GHIEHBEMIPF PMGBACFJIHO)
	{
		return default(ResourceID);
	}
}
