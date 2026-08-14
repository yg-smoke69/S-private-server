using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000644")]
public abstract class LevelLinkActivityDig<T> : BaseLevelObject where T : LevelLinkActivityDig<T>
{
	[Token(Token = "0x40046BE")]
	[FieldOffset(Offset = "0x0")]
	public uint LocateId;

	[Token(Token = "0x40046BF")]
	[FieldOffset(Offset = "0x0")]
	public Collider[] CenterPositions;

	[Token(Token = "0x40046C0")]
	[FieldOffset(Offset = "0x0")]
	protected COW.GamePlay.LPPBFEEJIKO<T> KAKLCADAIIJ;

	[Token(Token = "0x40046C1")]
	[FieldOffset(Offset = "0x0")]
	protected Collider FOMLLGLJKOF;

	[Token(Token = "0x40046C2")]
	[FieldOffset(Offset = "0x0")]
	protected int NPHCIJPNPMD;

	[Token(Token = "0x40046C3")]
	[FieldOffset(Offset = "0x0")]
	protected string MPNPFCPAGDO;

	[Token(Token = "0x40046C4")]
	[FieldOffset(Offset = "0x0")]
	public ResourceID TreasureModel;

	[Token(Token = "0x40046C5")]
	[FieldOffset(Offset = "0x0")]
	protected bool ECEABHCMLGA;

	[Token(Token = "0x40046C6")]
	[FieldOffset(Offset = "0x0")]
	protected bool PAIHJAMBIEJ;

	[Token(Token = "0x40046C7")]
	[FieldOffset(Offset = "0x0")]
	protected bool GOMCKJBLKIG;

	[Token(Token = "0x40046C8")]
	[FieldOffset(Offset = "0x0")]
	protected bool GBJKBGGEEEA;

	[Token(Token = "0x40046C9")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject DKKLCICIOLN;

	[Token(Token = "0x60026FF")]
	protected LevelLinkActivityDig()
	{
	}

	[Token(Token = "0x6002700")]
	public void InitActivity(COW.GamePlay.LPPBFEEJIKO<T> BJOPOLKPPLD, uint IDNEFEOPGIF, GameObject ALLMKNAMIBN, bool LLGMBELAFCD, bool BJCNIJFLDAF, bool MKENKJHPGLI, [Optional] LAOBFDEPEIB LAEHIOHKKMF)
	{
	}

	[Token(Token = "0x6002701")]
	private void LFFFNLMKJHM(GameObject OMDFNKNJDII)
	{
	}

	[Token(Token = "0x6002702")]
	protected abstract void NCHBOBOACGM();

	[Token(Token = "0x6002703")]
	protected virtual void IGMPIPOJMKD(bool BJCNIJFLDAF, bool LLGMBELAFCD, bool MKENKJHPGLI, [Optional] LAOBFDEPEIB LAEHIOHKKMF)
	{
	}

	[Token(Token = "0x6002704")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002705")]
	public virtual void OnFailed(bool AHOCFEABALI)
	{
	}

	[Token(Token = "0x6002706")]
	public virtual void OnSuccess()
	{
	}

	[Token(Token = "0x6002707")]
	protected virtual void JKDPOGCNPHD()
	{
	}

	[Token(Token = "0x6002708")]
	public virtual void OnFinish()
	{
	}

	[Token(Token = "0x6002709")]
	public virtual void OnAnyPlayerFinished()
	{
	}

	[Token(Token = "0x600270A")]
	public virtual void OnLocalPlayerEnter(GameObject OMDFNKNJDII)
	{
	}

	[Token(Token = "0x600270B")]
	public void OnLocalPlayerExit(GameObject OMDFNKNJDII)
	{
	}

	[Token(Token = "0x600270C")]
	public void OnCenterEnter(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x600270D")]
	protected virtual void NGEPKMNHFHO()
	{
	}

	[Token(Token = "0x600270E")]
	public void OnCenterExit(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x600270F")]
	private bool KBELPKJBLAG(Collider KODGAANKJBG)
	{
		return default(bool);
	}

	[Token(Token = "0x6002710")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002711")]
	protected void ECBOAJONNKO()
	{
	}

	[Token(Token = "0x6002712")]
	protected virtual bool LAFGPOPDLIO()
	{
		return default(bool);
	}

	[Token(Token = "0x6002713")]
	protected virtual void MLDBLJLIBNO()
	{
	}

	[Token(Token = "0x6002714")]
	protected void BGHEGMGHGGG()
	{
	}

	[Token(Token = "0x6002715")]
	protected bool CDAJFPGAPGO()
	{
		return default(bool);
	}

	[Token(Token = "0x6002716")]
	private void HLPCOLLPANJ()
	{
	}

	[Token(Token = "0x6002717")]
	private void NNEPBFMNLGC()
	{
	}

	[Token(Token = "0x6002718")]
	private void JBLJOABAMEH(object[] AJKBOONEOAB)
	{
	}
}
