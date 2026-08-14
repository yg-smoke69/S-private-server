using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20009AD")]
internal abstract class AKOPKPIDGEJ
{
	[Token(Token = "0x20009AE")]
	public enum OOCNCAKCHNO
	{
		[Token(Token = "0x40059D6")]
		NONE,
		[Token(Token = "0x40059D7")]
		FIRING,
		[Token(Token = "0x40059D8")]
		CANCEL
	}

	[Token(Token = "0x20009AF")]
	public enum HHMOMGDFCCJ
	{
		[Token(Token = "0x40059DA")]
		MANUL,
		[Token(Token = "0x40059DB")]
		AUTO,
		[Token(Token = "0x40059DC")]
		ICEWALLSMARTFIRE
	}

	[Token(Token = "0x20009B0")]
	public enum INLCHHLNNPM
	{
		[Token(Token = "0x40059DE")]
		Off,
		[Token(Token = "0x40059DF")]
		On
	}

	[Token(Token = "0x40059CB")]
	[FieldOffset(Offset = "0x8")]
	private OOCNCAKCHNO NNFDFMBDGMO;

	[Token(Token = "0x40059CC")]
	[FieldOffset(Offset = "0xC")]
	private HHMOMGDFCCJ DCEEKEFOFAG;

	[Token(Token = "0x40059CD")]
	[FieldOffset(Offset = "0x10")]
	private INLCHHLNNPM MHCDPJOOPAG;

	[Token(Token = "0x40059CE")]
	[FieldOffset(Offset = "0x14")]
	public bool EJPOHEOCJGC;

	[Token(Token = "0x40059CF")]
	[FieldOffset(Offset = "0x15")]
	public bool PNCJJIIHLEB;

	[Token(Token = "0x40059D0")]
	[FieldOffset(Offset = "0x0")]
	public static bool CKPNLJCGNCO;

	[Token(Token = "0x40059D1")]
	[FieldOffset(Offset = "0x1")]
	public static bool OFACDCHGGGO;

	[Token(Token = "0x40059D2")]
	[FieldOffset(Offset = "0x2")]
	public static bool AEPDPAGOGNF;

	[Token(Token = "0x40059D3")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 LLMPADJJPLB;

	[Token(Token = "0x40059D4")]
	[FieldOffset(Offset = "0x24")]
	public int CCCNMLCLNNG;

	[Token(Token = "0x170005F5")]
	public OOCNCAKCHNO NOOHCOJCNIA
	{
		[Token(Token = "0x6004AFF")]
		[Address(RVA = "0x1DF2838", Offset = "0x1DF2838", VA = "0x1DF2838")]
		get
		{
			return default(OOCNCAKCHNO);
		}
	}

	[Token(Token = "0x170005F6")]
	public HHMOMGDFCCJ JKDJHHMNGJF
	{
		[Token(Token = "0x6004B00")]
		[Address(RVA = "0x1DF2890", Offset = "0x1DF2890", VA = "0x1DF2890")]
		get
		{
			return default(HHMOMGDFCCJ);
		}
	}

	[Token(Token = "0x170005F7")]
	public INLCHHLNNPM IEOJHJLANBE
	{
		[Token(Token = "0x6004B01")]
		[Address(RVA = "0x1DF28E8", Offset = "0x1DF28E8", VA = "0x1DF28E8")]
		get
		{
			return default(INLCHHLNNPM);
		}
	}

	[Token(Token = "0x6004AFD")]
	[Address(RVA = "0x1DF2828", Offset = "0x1DF2828", VA = "0x1DF2828")]
	protected AKOPKPIDGEJ()
	{
	}

	[Token(Token = "0x6004AFE")]
	[Address(RVA = "0x1DE0A24", Offset = "0x1DE0A24", VA = "0x1DE0A24")]
	public void KBNOKPOCLED(OOCNCAKCHNO NPMEDEOKBID, HHMOMGDFCCJ OCANOIDGCHL = HHMOMGDFCCJ.MANUL)
	{
	}

	[Token(Token = "0x6004B02")]
	[Address(RVA = "0x1DE1FEC", Offset = "0x1DE1FEC", VA = "0x1DE1FEC")]
	public void KOCEEGODADA(INLCHHLNNPM PMGBACFJIHO)
	{
	}

	[Token(Token = "0x6004B03")]
	public abstract INMPHMMJOHB IJCOBIDNIAK();
}
