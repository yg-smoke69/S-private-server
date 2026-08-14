using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006F4")]
internal class MovableShootingTarget : AttackableEntity
{
	[Token(Token = "0x4004B85")]
	[FieldOffset(Offset = "0x48")]
	private Quaternion HFDJDCMFFBO;

	[Token(Token = "0x4004B86")]
	[FieldOffset(Offset = "0x58")]
	private Quaternion GMECKGHKJAO;

	[Token(Token = "0x4004B87")]
	[FieldOffset(Offset = "0x68")]
	private MovableShootingTargetData BOPLAOANKBI;

	[Token(Token = "0x4004B88")]
	[FieldOffset(Offset = "0x6C")]
	private GameObject PJBOFJPMCJB;

	[Token(Token = "0x4004B89")]
	[FieldOffset(Offset = "0x70")]
	private OMNPEFLEKOO DHDBGKDIHHO;

	[Token(Token = "0x4004B8A")]
	[FieldOffset(Offset = "0x74")]
	private bool GKFFHLNMGHH;

	[Token(Token = "0x4004B8B")]
	[FieldOffset(Offset = "0x78")]
	private float AKGGDLNLEHB;

	[Token(Token = "0x4004B8C")]
	[FieldOffset(Offset = "0x7C")]
	private int HDOAHHMGNOJ;

	[Token(Token = "0x4004B8D")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 OJKAPPIOGGM;

	[Token(Token = "0x4004B8E")]
	[FieldOffset(Offset = "0x8C")]
	private float DJFGHHAPAJL;

	[Token(Token = "0x4004B8F")]
	[FieldOffset(Offset = "0x90")]
	private float MHONCHIHHOB;

	[Token(Token = "0x4004B90")]
	[FieldOffset(Offset = "0x94")]
	private float EGEIOABAKNK;

	[Token(Token = "0x4004B91")]
	[FieldOffset(Offset = "0x98")]
	private List<Vector3> NOEPIANHCIA;

	[Token(Token = "0x4004B92")]
	[FieldOffset(Offset = "0x9C")]
	private bool LENACMJNFPF;

	[Token(Token = "0x4004B93")]
	[FieldOffset(Offset = "0xA0")]
	private CBNIKECJHAN LPENOCNINFK;

	[Token(Token = "0x6002C5C")]
	[Address(RVA = "0x1BED348", Offset = "0x1BED348", VA = "0x1BED348")]
	public MovableShootingTarget()
	{
	}

	[Token(Token = "0x6002C5D")]
	[Address(RVA = "0x1BED3D4", Offset = "0x1BED3D4", VA = "0x1BED3D4", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002C5E")]
	[Address(RVA = "0x1BEDF30", Offset = "0x1BEDF30", VA = "0x1BEDF30", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002C5F")]
	[Address(RVA = "0x1BEE0F8", Offset = "0x1BEE0F8", VA = "0x1BEE0F8")]
	private void BKHHEOLMKBM(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6002C60")]
	[Address(RVA = "0x1BEE344", Offset = "0x1BEE344", VA = "0x1BEE344", Slot = "58")]
	protected override void OnDead()
	{
	}

	[Token(Token = "0x6002C61")]
	[Address(RVA = "0x1BEE5AC", Offset = "0x1BEE5AC", VA = "0x1BEE5AC", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002C62")]
	[Address(RVA = "0x1BEE8AC", Offset = "0x1BEE8AC", VA = "0x1BEE8AC")]
	private void BJDJFMAJAGE()
	{
	}

	[Token(Token = "0x6002C63")]
	[Address(RVA = "0x1BEDCB0", Offset = "0x1BEDCB0", VA = "0x1BEDCB0")]
	private void BHOPALIFOJE(OAKMMHOLHCI PMGBACFJIHO)
	{
	}

	[Token(Token = "0x6002C64")]
	[Address(RVA = "0x1BEEBA0", Offset = "0x1BEEBA0", VA = "0x1BEEBA0", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002C65")]
	[Address(RVA = "0x1BEF19C", Offset = "0x1BEF19C", VA = "0x1BEF19C", Slot = "49")]
	public override float GetAttackableRadius()
	{
		return default(float);
	}

	[Token(Token = "0x6002C66")]
	[Address(RVA = "0x1BEF1F4", Offset = "0x1BEF1F4", VA = "0x1BEF1F4", Slot = "48")]
	public override Vector3 GetAttackableCenterWS()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002C67")]
	[Address(RVA = "0x1BEF28C", Offset = "0x1BEF28C", VA = "0x1BEF28C", Slot = "50")]
	public override Vector3 GetHitDamagePos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002C68")]
	[Address(RVA = "0x1BEF324", Offset = "0x1BEF324", VA = "0x1BEF324", Slot = "51")]
	public override bool NeedAssit()
	{
		return default(bool);
	}

	[Token(Token = "0x6002C69")]
	[Address(RVA = "0x1BEF428", Offset = "0x1BEF428", VA = "0x1BEF428", Slot = "53")]
	public override bool IsSameTeamWithPlayerID(IHAAMHPPLMG FGFGBHLEONO)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C6A")]
	[Address(RVA = "0x1BEF4C0", Offset = "0x1BEF4C0", VA = "0x1BEF4C0", Slot = "59")]
	public override uint GetAttackableID()
	{
		return default(uint);
	}

	[Token(Token = "0x6002C6B")]
	[Address(RVA = "0x1BEF524", Offset = "0x1BEF524", VA = "0x1BEF524")]
	public OMNPEFLEKOO GetCurState()
	{
		return default(OMNPEFLEKOO);
	}

	[Token(Token = "0x6002C6C")]
	[Address(RVA = "0x1BEF57C", Offset = "0x1BEF57C", VA = "0x1BEF57C", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint EMFANFHKAMM = 0u)
	{
	}

	[Token(Token = "0x6002C6D")]
	[Address(RVA = "0x1BEFF0C", Offset = "0x1BEFF0C", VA = "0x1BEFF0C", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002C6E")]
	[Address(RVA = "0x1BEFF64", Offset = "0x1BEFF64", VA = "0x1BEFF64")]
	public void TakeLocalGrenadeDamage(float JLKLMFHFHFF)
	{
	}

	[Token(Token = "0x6002C6F")]
	[Address(RVA = "0x1BF06F0", Offset = "0x1BF06F0", VA = "0x1BF06F0")]
	public bool CanTakeDamageInGrenadePractice()
	{
		return default(bool);
	}

	[Token(Token = "0x6002C70")]
	[Address(RVA = "0x1BF0804", Offset = "0x1BF0804", VA = "0x1BF0804")]
	public void UpdateTargetInGameState(OMNPEFLEKOO GLDLCOBLGNF, bool NDDOHPIBAPJ)
	{
	}

	[Token(Token = "0x6002C71")]
	[Address(RVA = "0x1BF0B64", Offset = "0x1BF0B64", VA = "0x1BF0B64")]
	public bool IsSelectdInShootingGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6002C72")]
	[Address(RVA = "0x1BF0C68", Offset = "0x1BF0C68", VA = "0x1BF0C68")]
	public MovableShootingTargetData GetData()
	{
		return null;
	}

	[Token(Token = "0x6002C73")]
	[Address(RVA = "0x1BF0CC0", Offset = "0x1BF0CC0", VA = "0x1BF0CC0")]
	public bool InLocalGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6002C74")]
	[Address(RVA = "0x1BF0D18", Offset = "0x1BF0D18", VA = "0x1BF0D18")]
	public void SetHp(float ABLGPCAPELM)
	{
	}

	[Token(Token = "0x6002C75")]
	[Address(RVA = "0x1BF0D7C", Offset = "0x1BF0D7C", VA = "0x1BF0D7C")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002C76")]
	[Address(RVA = "0x1BF0D84", Offset = "0x1BF0D84", VA = "0x1BF0D84")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x6002C77")]
	[Address(RVA = "0x1BF0D8C", Offset = "0x1BF0D8C", VA = "0x1BF0D8C")]
	public void _003C_003EiFixBaseProxy_OnDead()
	{
	}

	[Token(Token = "0x6002C78")]
	[Address(RVA = "0x1BF0D94", Offset = "0x1BF0D94", VA = "0x1BF0D94")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6002C79")]
	[Address(RVA = "0x1BF0D9C", Offset = "0x1BF0D9C", VA = "0x1BF0D9C")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6002C7A")]
	[Address(RVA = "0x1BF0DA4", Offset = "0x1BF0DA4", VA = "0x1BF0DA4")]
	public float _003C_003EiFixBaseProxy_GetAttackableRadius()
	{
		return default(float);
	}

	[Token(Token = "0x6002C7B")]
	[Address(RVA = "0x1BF0DAC", Offset = "0x1BF0DAC", VA = "0x1BF0DAC")]
	public Vector3 _003C_003EiFixBaseProxy_GetAttackableCenterWS()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002C7C")]
	[Address(RVA = "0x1BF0DC0", Offset = "0x1BF0DC0", VA = "0x1BF0DC0")]
	public Vector3 _003C_003EiFixBaseProxy_GetHitDamagePos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002C7D")]
	[Address(RVA = "0x1BF0DD4", Offset = "0x1BF0DD4", VA = "0x1BF0DD4")]
	public bool _003C_003EiFixBaseProxy_NeedAssit()
	{
		return default(bool);
	}

	[Token(Token = "0x6002C7E")]
	[Address(RVA = "0x1BF0DDC", Offset = "0x1BF0DDC", VA = "0x1BF0DDC")]
	public bool _003C_003EiFixBaseProxy_IsSameTeamWithPlayerID(IHAAMHPPLMG P0)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C7F")]
	[Address(RVA = "0x1BF0E10", Offset = "0x1BF0E10", VA = "0x1BF0E10")]
	public uint _003C_003EiFixBaseProxy_GetAttackableID()
	{
		return default(uint);
	}

	[Token(Token = "0x6002C80")]
	[Address(RVA = "0x1BF0E18", Offset = "0x1BF0E18", VA = "0x1BF0E18")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
