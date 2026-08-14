using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200068E")]
public class LevelReviveTower : BaseLevelObject
{
	[Token(Token = "0x200068F")]
	public enum DFDNJAEHABB
	{
		[Token(Token = "0x40048A5")]
		UpdateLinkInfo
	}

	[Token(Token = "0x400489B")]
	[FieldOffset(Offset = "0x74")]
	private float CKAHCHEEBMM;

	[Token(Token = "0x400489C")]
	[FieldOffset(Offset = "0x78")]
	private bool JJPEGDGKEAG;

	[Token(Token = "0x400489D")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject m_LigthenEffect;

	[Token(Token = "0x400489E")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_BannedEffect;

	[Token(Token = "0x400489F")]
	[FieldOffset(Offset = "0x84")]
	public GameObject m_Shield;

	[Token(Token = "0x40048A0")]
	[FieldOffset(Offset = "0x88")]
	public Collider m_PlayerTrigger;

	[Token(Token = "0x40048A1")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 m_LineStartOffset;

	[Token(Token = "0x40048A2")]
	[FieldOffset(Offset = "0x98")]
	public Vector3 m_LineEndOffset;

	[Token(Token = "0x40048A3")]
	[FieldOffset(Offset = "0xA4")]
	public LineRenderer[] m_LinkLineRenders;

	[Token(Token = "0x1700033C")]
	public bool NEHHOJECHEI
	{
		[Token(Token = "0x6002A11")]
		[Address(RVA = "0x20CBCDC", Offset = "0x20CBCDC", VA = "0x20CBCDC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700033D")]
	public bool KALPOACABFN
	{
		[Token(Token = "0x6002A12")]
		[Address(RVA = "0x20CBE08", Offset = "0x20CBE08", VA = "0x20CBE08")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002A10")]
	[Address(RVA = "0x20CBCD4", Offset = "0x20CBCD4", VA = "0x20CBCD4")]
	public LevelReviveTower()
	{
	}

	[Token(Token = "0x6002A13")]
	[Address(RVA = "0x20CBF98", Offset = "0x20CBF98", VA = "0x20CBF98", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002A14")]
	[Address(RVA = "0x20CC03C", Offset = "0x20CC03C", VA = "0x20CC03C", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002A15")]
	[Address(RVA = "0x20CC164", Offset = "0x20CC164", VA = "0x20CC164", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002A16")]
	[Address(RVA = "0x20CC4B0", Offset = "0x20CC4B0", VA = "0x20CC4B0", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002A17")]
	[Address(RVA = "0x20CC508", Offset = "0x20CC508", VA = "0x20CC508")]
	protected void DEINIPGNACC(uint JFHIANHLOFM, uint JEHELPNHACP)
	{
	}

	[Token(Token = "0x6002A18")]
	[Address(RVA = "0x20CC8F8", Offset = "0x20CC8F8", VA = "0x20CC8F8")]
	protected void NEDPPCANIHD(int GAPEEPJBELC, int ALBCLDBLPLD)
	{
	}

	[Token(Token = "0x6002A19")]
	[Address(RVA = "0x20CCA24", Offset = "0x20CCA24", VA = "0x20CCA24")]
	private void MBGBJJHMNOG(bool OGCENEBONAB, bool BJCECPLMHLH)
	{
	}

	[Token(Token = "0x6002A1A")]
	[Address(RVA = "0x20CCB44", Offset = "0x20CCB44", VA = "0x20CCB44", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002A1B")]
	[Address(RVA = "0x20CCC78", Offset = "0x20CCC78", VA = "0x20CCC78", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002A1C")]
	[Address(RVA = "0x20CCDD0", Offset = "0x20CCDD0", VA = "0x20CCDD0")]
	private void KIENFPDKKLA(Vector3 EEJIIIPJCNJ, bool JIOLGHPFOHL)
	{
	}

	[Token(Token = "0x6002A1D")]
	[Address(RVA = "0x20CD074", Offset = "0x20CD074", VA = "0x20CD074")]
	private void Update()
	{
	}

	[Token(Token = "0x6002A1E")]
	[Address(RVA = "0x20CD12C", Offset = "0x20CD12C", VA = "0x20CD12C")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002A1F")]
	[Address(RVA = "0x20CD134", Offset = "0x20CD134", VA = "0x20CD134")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002A20")]
	[Address(RVA = "0x20CD13C", Offset = "0x20CD13C", VA = "0x20CD13C")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002A21")]
	[Address(RVA = "0x20CD144", Offset = "0x20CD144", VA = "0x20CD144")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	[Token(Token = "0x6002A22")]
	[Address(RVA = "0x20CD14C", Offset = "0x20CD14C", VA = "0x20CD14C")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
