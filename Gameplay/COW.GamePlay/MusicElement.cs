using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006FA")]
internal class MusicElement : AttackableEntity
{
	[Token(Token = "0x20006FB")]
	private enum FODHJJGPJCO
	{
		[Token(Token = "0x4004BC0")]
		Hit,
		[Token(Token = "0x4004BC1")]
		PlayerEnter
	}

	[Token(Token = "0x4004BB3")]
	[FieldOffset(Offset = "0x48")]
	public uint m_ID;

	[Token(Token = "0x4004BB4")]
	[FieldOffset(Offset = "0x4C")]
	private float CIICGIKKEGP;

	[Token(Token = "0x4004BB5")]
	[FieldOffset(Offset = "0x50")]
	private float JDBNLIBMKDN;

	[Token(Token = "0x4004BB6")]
	[FieldOffset(Offset = "0x54")]
	public string m_ResourceStr;

	[Token(Token = "0x4004BB7")]
	[FieldOffset(Offset = "0x58")]
	public string m_VFX_ResourceStr;

	[Token(Token = "0x4004BB8")]
	[FieldOffset(Offset = "0x5C")]
	private ResourceID PJDAGJBEFEE;

	[Token(Token = "0x4004BB9")]
	[FieldOffset(Offset = "0x60")]
	private ResourceID DKGNJGHOFGC;

	[Token(Token = "0x4004BBA")]
	[FieldOffset(Offset = "0x64")]
	private GameObject CBJEBAODDBL;

	[Token(Token = "0x4004BBB")]
	[FieldOffset(Offset = "0x68")]
	private bool CNCJPPBNNCK;

	[Token(Token = "0x4004BBC")]
	[FieldOffset(Offset = "0x69")]
	private bool GPEFFMOHLOP;

	[Token(Token = "0x4004BBD")]
	[FieldOffset(Offset = "0x6C")]
	private FODHJJGPJCO POHPFALLFEG;

	[Token(Token = "0x4004BBE")]
	[FieldOffset(Offset = "0x70")]
	private uint MHAIGHPNGEO;

	[Token(Token = "0x6002C91")]
	[Address(RVA = "0x1BF78E8", Offset = "0x1BF78E8", VA = "0x1BF78E8")]
	public MusicElement()
	{
	}

	[Token(Token = "0x6002C92")]
	[Address(RVA = "0x1BF7A04", Offset = "0x1BF7A04", VA = "0x1BF7A04", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002C93")]
	[Address(RVA = "0x1BF7E84", Offset = "0x1BF7E84", VA = "0x1BF7E84")]
	public void SetUGCResourceID(int FCNCLDCEPGM)
	{
	}

	[Token(Token = "0x6002C94")]
	[Address(RVA = "0x1BF8124", Offset = "0x1BF8124", VA = "0x1BF8124", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002C95")]
	[Address(RVA = "0x1BF8510", Offset = "0x1BF8510", VA = "0x1BF8510")]
	public void OnPlayerEnter()
	{
	}

	[Token(Token = "0x6002C96")]
	[Address(RVA = "0x1BF86B4", Offset = "0x1BF86B4", VA = "0x1BF86B4")]
	public void OnPlayerExit()
	{
	}

	[Token(Token = "0x6002C97")]
	[Address(RVA = "0x1BF829C", Offset = "0x1BF829C", VA = "0x1BF829C")]
	public void AutoPlayVFX(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x6002C98")]
	[Address(RVA = "0x1BF8708", Offset = "0x1BF8708", VA = "0x1BF8708", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002C99")]
	[Address(RVA = "0x1BF8760", Offset = "0x1BF8760", VA = "0x1BF8760", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint EMFANFHKAMM = 0u)
	{
	}

	[Token(Token = "0x6002C9A")]
	[Address(RVA = "0x1BF87F0", Offset = "0x1BF87F0", VA = "0x1BF87F0")]
	public void SendPlayingVoice()
	{
	}

	[Token(Token = "0x6002C9B")]
	[Address(RVA = "0x1BF8578", Offset = "0x1BF8578", VA = "0x1BF8578")]
	private void IOIHFDGNJHL()
	{
	}

	[Token(Token = "0x6002C9C")]
	[Address(RVA = "0x1BF8A38", Offset = "0x1BF8A38", VA = "0x1BF8A38")]
	public void PlaySoundAndEffect(bool LFPIAIGOJJO = true)
	{
	}

	[Token(Token = "0x6002C9D")]
	[Address(RVA = "0x1BF8910", Offset = "0x1BF8910", VA = "0x1BF8910")]
	private bool BBGMDKKDLKO()
	{
		return default(bool);
	}

	[Token(Token = "0x6002C9E")]
	[Address(RVA = "0x1BF8F24", Offset = "0x1BF8F24", VA = "0x1BF8F24")]
	private void EJPEDOAFOEC(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6002C9F")]
	[Address(RVA = "0x1BF8DA4", Offset = "0x1BF8DA4", VA = "0x1BF8DA4")]
	private bool EPBMHKGCJDF()
	{
		return default(bool);
	}

	[Token(Token = "0x6002CA0")]
	[Address(RVA = "0x1BF90F0", Offset = "0x1BF90F0", VA = "0x1BF90F0")]
	private void OPEKHEADEKO()
	{
	}

	[Token(Token = "0x6002CA1")]
	[Address(RVA = "0x1BF9350", Offset = "0x1BF9350", VA = "0x1BF9350")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002CA2")]
	[Address(RVA = "0x1BF9358", Offset = "0x1BF9358", VA = "0x1BF9358")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x6002CA3")]
	[Address(RVA = "0x1BF9360", Offset = "0x1BF9360", VA = "0x1BF9360")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
