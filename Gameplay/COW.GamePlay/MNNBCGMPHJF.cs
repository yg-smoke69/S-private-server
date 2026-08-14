using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x20004E7")]
public class MNNBCGMPHJF : CSVBaseData, _Attribute
{
	[Token(Token = "0x20004E8")]
	public enum PNNDOLFEBEL
	{
		[Token(Token = "0x40040B3")]
		NONE,
		[Token(Token = "0x40040B4")]
		BIG_HEAD
	}

	[Token(Token = "0x40040AE")]
	[FieldOffset(Offset = "0x8")]
	public PNNDOLFEBEL ININLGONOJF;

	[Token(Token = "0x40040AF")]
	[FieldOffset(Offset = "0xC")]
	public uint[] GPNLAHBMNEM;

	[Token(Token = "0x40040B0")]
	[FieldOffset(Offset = "0x10")]
	public float NICKCCFAOJI;

	[Token(Token = "0x40040B1")]
	[FieldOffset(Offset = "0x14")]
	public int KKOAOPMEADH;

	[Token(Token = "0x60019A7")]
	[Address(RVA = "0x1BEA608", Offset = "0x1BEA608", VA = "0x1BEA608")]
	public MNNBCGMPHJF()
	{
	}

	[Token(Token = "0x60019A8")]
	[Address(RVA = "0x1BEA68C", Offset = "0x1BEA68C", VA = "0x1BEA68C", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60019A9")]
	[Address(RVA = "0x1BEA6E4", Offset = "0x1BEA6E4", VA = "0x1BEA6E4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60019AA")]
	[Address(RVA = "0x1BEA7E4", Offset = "0x1BEA7E4", VA = "0x1BEA7E4", Slot = "4")]
	public override void ParseData(long HHLONFLCJBL, int KHCPMMPFLJC, string[] HBKMAMHJAIK, string[] LEDOBKGBDAJ)
	{
	}
}
