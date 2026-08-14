using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000600")]
public class LevelControlPoint : BaseLevelObject
{
	[Token(Token = "0x4004530")]
	[FieldOffset(Offset = "0x74")]
	public string ShowName;

	[Token(Token = "0x4004531")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_EffectGO;

	[Token(Token = "0x4004532")]
	[FieldOffset(Offset = "0x7C")]
	protected bool KDIJLCNGCMI;

	[Token(Token = "0x4004533")]
	public const uint CONTROL_SCRAMBLE_TEAM_IDX = 3u;

	[Token(Token = "0x4004534")]
	public const uint CONTROL_INVALID_TEAM_IDX = 0u;

	[Token(Token = "0x4004535")]
	[FieldOffset(Offset = "0x80")]
	public Color[] EmptyStateColorArray;

	[Token(Token = "0x4004536")]
	[FieldOffset(Offset = "0x84")]
	public Color[] LocalControlColorArray;

	[Token(Token = "0x4004537")]
	[FieldOffset(Offset = "0x88")]
	public Color[] OppControlColorArray;

	[Token(Token = "0x4004538")]
	[FieldOffset(Offset = "0x8C")]
	public Color[] ScrambleColorArray;

	[Token(Token = "0x4004539")]
	[FieldOffset(Offset = "0x90")]
	private UIModelMatch KFGFEONAIIK;

	[Token(Token = "0x400453A")]
	[FieldOffset(Offset = "0x0")]
	private static Action HMDOHFBHDOB;

	[Token(Token = "0x170002EA")]
	public bool DDFIEBENFHC
	{
		[Token(Token = "0x60024DC")]
		[Address(RVA = "0x2391470", Offset = "0x2391470", VA = "0x2391470")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60024D3")]
	[Address(RVA = "0x2390680", Offset = "0x2390680", VA = "0x2390680")]
	public LevelControlPoint()
	{
	}

	[Token(Token = "0x60024D4")]
	[Address(RVA = "0x2390688", Offset = "0x2390688", VA = "0x2390688", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60024D5")]
	[Address(RVA = "0x2390BA0", Offset = "0x2390BA0", VA = "0x2390BA0", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60024D6")]
	[Address(RVA = "0x2390C44", Offset = "0x2390C44", VA = "0x2390C44", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60024D7")]
	[Address(RVA = "0x2390C9C", Offset = "0x2390C9C", VA = "0x2390C9C", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60024D8")]
	[Address(RVA = "0x23911D0", Offset = "0x23911D0", VA = "0x23911D0", Slot = "40")]
	protected virtual void PNNDNFACMLK(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60024D9")]
	[Address(RVA = "0x239159C", Offset = "0x239159C", VA = "0x239159C", Slot = "41")]
	protected virtual void LJNCBKGPLDN(int JGLJDJFHPBO, int DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60024DA")]
	[Address(RVA = "0x239160C", Offset = "0x239160C", VA = "0x239160C", Slot = "42")]
	protected virtual void EFPMPAAGAMO(int JGLJDJFHPBO, int DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60024DB")]
	[Address(RVA = "0x239167C", Offset = "0x239167C", VA = "0x239167C", Slot = "43")]
	protected virtual void MMFJMCLFMEM(int JGLJDJFHPBO, int DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60024DD")]
	[Address(RVA = "0x2391C24", Offset = "0x2391C24", VA = "0x2391C24", Slot = "44")]
	protected virtual void HNGHMPMABAH(byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60024DE")]
	[Address(RVA = "0x2391D78", Offset = "0x2391D78", VA = "0x2391D78", Slot = "45")]
	protected virtual void OILCNKGNKOO(byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60024DF")]
	[Address(RVA = "0x23907C8", Offset = "0x23907C8", VA = "0x23907C8")]
	protected void CEHHLMFFNEL(Color[] NHJFJGEGMNF)
	{
	}

	[Token(Token = "0x60024E0")]
	[Address(RVA = "0x2391E14", Offset = "0x2391E14", VA = "0x2391E14", Slot = "46")]
	protected virtual void GADEKPGMFID(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60024E1")]
	[Address(RVA = "0x2391E84", Offset = "0x2391E84", VA = "0x2391E84")]
	private static void LJEEJNPAHAN()
	{
	}

	[Token(Token = "0x60024E2")]
	[Address(RVA = "0x2392238", Offset = "0x2392238", VA = "0x2392238")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x60024E3")]
	[Address(RVA = "0x2392240", Offset = "0x2392240", VA = "0x2392240")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60024E4")]
	[Address(RVA = "0x2392248", Offset = "0x2392248", VA = "0x2392248")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}
}
