using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x200061D")]
internal class LevelEscortMatchBoss : BaseLevelObject
{
	[Token(Token = "0x200061E")]
	private class HHCBNAPCKHF : ShadowStateBase
	{
		[Token(Token = "0x4004602")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 JHJLNLCEGOG;

		[Token(Token = "0x4004603")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 PGDEDHFOMCN;

		[Token(Token = "0x4004604")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion FBMPKHMBHAM;

		[Token(Token = "0x4004605")]
		[FieldOffset(Offset = "0x38")]
		public Quaternion BPLOAFBIHJL;

		[Token(Token = "0x60025E0")]
		[Address(RVA = "0x271C290", Offset = "0x271C290", VA = "0x271C290")]
		public HHCBNAPCKHF()
		{
		}
	}

	[Token(Token = "0x40045E7")]
	[FieldOffset(Offset = "0x74")]
	public EscortMatchBoss m_EscortMatchBoss;

	[Token(Token = "0x40045E8")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_MovingEffect;

	[Token(Token = "0x40045E9")]
	[FieldOffset(Offset = "0x7C")]
	private uint JMCOJOJMFOD;

	[Token(Token = "0x40045EA")]
	[FieldOffset(Offset = "0x80")]
	private uint NKGLLIHNILB;

	[Token(Token = "0x40045EB")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 CMGAPGBEKLM;

	[Token(Token = "0x40045EC")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_ShiledObj;

	[Token(Token = "0x40045ED")]
	[FieldOffset(Offset = "0x94")]
	public GameObject m_RechargeEffect;

	[Token(Token = "0x40045EE")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_BrokenEffect;

	[Token(Token = "0x40045EF")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject m_NormalEffect;

	[Token(Token = "0x40045F0")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_HitEffect;

	[Token(Token = "0x40045F1")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject m_AttackRingEffect;

	[Token(Token = "0x40045F2")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_DefendRingEffect;

	[Token(Token = "0x40045F3")]
	[FieldOffset(Offset = "0xAC")]
	public TweenScale m_ShiledMoveColliderTw;

	[Token(Token = "0x40045F4")]
	[FieldOffset(Offset = "0xB0")]
	private BoxCollider GANDMBGHMAM;

	[Token(Token = "0x40045F5")]
	[FieldOffset(Offset = "0xB4")]
	private BoxCollider ECMIIOANEBP;

	[Token(Token = "0x40045F6")]
	[FieldOffset(Offset = "0xB8")]
	private Vector3 KKPCDFFDGMF;

	[Token(Token = "0x40045F7")]
	[FieldOffset(Offset = "0xC4")]
	private BoxCollider MPOJNCNOCNI;

	[Token(Token = "0x40045F8")]
	[FieldOffset(Offset = "0xC8")]
	protected uint KINJCKMOGIM;

	[Token(Token = "0x40045F9")]
	[FieldOffset(Offset = "0xCC")]
	private HHCBNAPCKHF PLGAAJABBHA;

	[Token(Token = "0x40045FA")]
	[FieldOffset(Offset = "0xD0")]
	private EIJGEMFMHLJ ILGECLEFCCO;

	[Token(Token = "0x40045FB")]
	[FieldOffset(Offset = "0xD4")]
	private float BJJAGGLLLCK;

	[Token(Token = "0x40045FC")]
	[FieldOffset(Offset = "0xD8")]
	private GameObject EPKEHAOJGCK;

	[Token(Token = "0x40045FD")]
	[FieldOffset(Offset = "0xDC")]
	private bool EIMPFMIFPMJ;

	[Token(Token = "0x40045FE")]
	[FieldOffset(Offset = "0xE0")]
	private Animator KFGPIOMOLHI;

	[Token(Token = "0x40045FF")]
	[FieldOffset(Offset = "0xE4")]
	private EIJGEMFMHLJ CJCBNOCMLGC;

	[Token(Token = "0x4004600")]
	[FieldOffset(Offset = "0xE8")]
	protected GameObject EKADAMIMHKN;

	[Token(Token = "0x4004601")]
	[FieldOffset(Offset = "0xEC")]
	protected AudioResource KNOCMNKMGON;

	[Token(Token = "0x170002F0")]
	public uint MIALLOCOJNP
	{
		[Token(Token = "0x60025C6")]
		[Address(RVA = "0x271E81C", Offset = "0x271E81C", VA = "0x271E81C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170002F1")]
	public uint JKICHPGKBEP
	{
		[Token(Token = "0x60025C7")]
		[Address(RVA = "0x271E944", Offset = "0x271E944", VA = "0x271E944")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170002F2")]
	public uint GOHBNDGKCEP
	{
		[Token(Token = "0x60025C8")]
		[Address(RVA = "0x271EA6C", Offset = "0x271EA6C", VA = "0x271EA6C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170002F3")]
	public EIJGEMFMHLJ DIJEONBMIOH
	{
		[Token(Token = "0x60025C9")]
		[Address(RVA = "0x271E014", Offset = "0x271E014", VA = "0x271E014")]
		get
		{
			return default(EIJGEMFMHLJ);
		}
	}

	[Token(Token = "0x170002F4")]
	public float BPAGMFHCDFH
	{
		[Token(Token = "0x60025CC")]
		[Address(RVA = "0x271EC8C", Offset = "0x271EC8C", VA = "0x271EC8C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002F5")]
	public float FNEGLAPNBOA
	{
		[Token(Token = "0x60025CD")]
		[Address(RVA = "0x271ED8C", Offset = "0x271ED8C", VA = "0x271ED8C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60025BD")]
	[Address(RVA = "0x271C214", Offset = "0x271C214", VA = "0x271C214")]
	public LevelEscortMatchBoss()
	{
	}

	[Token(Token = "0x60025BE")]
	[Address(RVA = "0x271C298", Offset = "0x271C298", VA = "0x271C298", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60025BF")]
	[Address(RVA = "0x271C6A4", Offset = "0x271C6A4", VA = "0x271C6A4", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x60025C0")]
	[Address(RVA = "0x271D964", Offset = "0x271D964", VA = "0x271D964")]
	public void OnCurrRoundChanged()
	{
	}

	[Token(Token = "0x60025C1")]
	[Address(RVA = "0x271DB5C", Offset = "0x271DB5C", VA = "0x271DB5C")]
	public void UpdateRingEffect()
	{
	}

	[Token(Token = "0x60025C2")]
	[Address(RVA = "0x271DDA4", Offset = "0x271DDA4", VA = "0x271DDA4")]
	private void EBLBAGFOEBH()
	{
	}

	[Token(Token = "0x60025C3")]
	[Address(RVA = "0x271DEE8", Offset = "0x271DEE8", VA = "0x271DEE8")]
	public Vector3 GetTopPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60025C4")]
	[Address(RVA = "0x271D308", Offset = "0x271D308", VA = "0x271D308")]
	private void ADJHJOCPFNJ(Vector3 MLCIHBOHEHE, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x60025C5")]
	[Address(RVA = "0x271E13C", Offset = "0x271E13C", VA = "0x271E13C", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60025CA")]
	[Address(RVA = "0x271EB94", Offset = "0x271EB94", VA = "0x271EB94")]
	public bool NeedCure()
	{
		return default(bool);
	}

	[Token(Token = "0x60025CB")]
	[Address(RVA = "0x271EC04", Offset = "0x271EC04", VA = "0x271EC04")]
	public bool IsMoving()
	{
		return default(bool);
	}

	[Token(Token = "0x60025CE")]
	[Address(RVA = "0x271EEB8", Offset = "0x271EEB8", VA = "0x271EEB8")]
	protected void FELGPDBBNHL(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60025CF")]
	[Address(RVA = "0x271F538", Offset = "0x271F538", VA = "0x271F538")]
	protected void NACPDAICPMJ(NFELFILIHII GIOJBHNKENO)
	{
	}

	[Token(Token = "0x60025D0")]
	[Address(RVA = "0x271F69C", Offset = "0x271F69C", VA = "0x271F69C")]
	protected void PEKOKIODAOB(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60025D1")]
	[Address(RVA = "0x271F8F4", Offset = "0x271F8F4", VA = "0x271F8F4", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60025D2")]
	[Address(RVA = "0x271F94C", Offset = "0x271F94C", VA = "0x271F94C")]
	protected void OHKBEJOLNLH(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60025D3")]
	[Address(RVA = "0x2720148", Offset = "0x2720148", VA = "0x2720148")]
	public void OnSyncStateIndex(uint EHJAKJGKJGH)
	{
	}

	[Token(Token = "0x60025D4")]
	[Address(RVA = "0x271E634", Offset = "0x271E634", VA = "0x271E634")]
	private void EOJGFPMMHPJ()
	{
	}

	[Token(Token = "0x60025D5")]
	[Address(RVA = "0x27208AC", Offset = "0x27208AC", VA = "0x27208AC")]
	protected void IBIEAOPKOAO(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60025D6")]
	[Address(RVA = "0x2720A64", Offset = "0x2720A64", VA = "0x2720A64", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60025D7")]
	[Address(RVA = "0x2720B08", Offset = "0x2720B08", VA = "0x2720B08", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x60025D8")]
	[Address(RVA = "0x2720B6C", Offset = "0x2720B6C", VA = "0x2720B6C")]
	public void ShowHitEffect(Vector3 DOBOBMFMKBJ)
	{
	}

	[Token(Token = "0x60025D9")]
	[Address(RVA = "0x2720D14", Offset = "0x2720D14", VA = "0x2720D14", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60025DA")]
	[Address(RVA = "0x2721050", Offset = "0x2721050", VA = "0x2721050")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x60025DB")]
	[Address(RVA = "0x2721058", Offset = "0x2721058", VA = "0x2721058")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x60025DC")]
	[Address(RVA = "0x2721060", Offset = "0x2721060", VA = "0x2721060")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60025DD")]
	[Address(RVA = "0x2721068", Offset = "0x2721068", VA = "0x2721068")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60025DE")]
	[Address(RVA = "0x2721070", Offset = "0x2721070", VA = "0x2721070")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x60025DF")]
	[Address(RVA = "0x2721078", Offset = "0x2721078", VA = "0x2721078")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
