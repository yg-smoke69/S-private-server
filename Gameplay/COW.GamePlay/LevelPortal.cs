using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200067E")]
public class LevelPortal : BaseLevelObject
{
	[Token(Token = "0x200067F")]
	private sealed class PLAMCHOGADO
	{
		[Token(Token = "0x4004833")]
		[FieldOffset(Offset = "0x8")]
		internal Action OBKBCKDIAEF;

		[Token(Token = "0x4004834")]
		[FieldOffset(Offset = "0xC")]
		internal LevelPortal GADHAMJEKIM;

		[Token(Token = "0x6002998")]
		[Address(RVA = "0x20BDA80", Offset = "0x20BDA80", VA = "0x20BDA80")]
		public PLAMCHOGADO()
		{
		}

		[Token(Token = "0x6002999")]
		[Address(RVA = "0x20BDEC4", Offset = "0x20BDEC4", VA = "0x20BDEC4")]
		internal void CHOPCLCOBKC()
		{
		}

		[Token(Token = "0x600299A")]
		[Address(RVA = "0x20BE1FC", Offset = "0x20BE1FC", VA = "0x20BE1FC")]
		internal void HJGBDJENEAM()
		{
		}
	}

	[Token(Token = "0x4004825")]
	[FieldOffset(Offset = "0x74")]
	public OGIGAFPGKDI PortalType;

	[Token(Token = "0x4004826")]
	[FieldOffset(Offset = "0x78")]
	public float Radius;

	[Token(Token = "0x4004827")]
	[FieldOffset(Offset = "0x7C")]
	public Transform[] SpawnPoints;

	[Token(Token = "0x4004828")]
	[FieldOffset(Offset = "0x80")]
	private uint MMNFABGNKAJ;

	[Token(Token = "0x4004829")]
	[FieldOffset(Offset = "0x84")]
	public ParticleSystem SocialZoneNormalEffect;

	[Token(Token = "0x400482A")]
	[FieldOffset(Offset = "0x88")]
	public ParticleSystem BattleZoneNormalEffect;

	[Token(Token = "0x400482B")]
	[FieldOffset(Offset = "0x8C")]
	public ParticleSystem SocialZoneEnterEffect;

	[Token(Token = "0x400482C")]
	[FieldOffset(Offset = "0x90")]
	public ParticleSystem BattleZoneEnterEffect;

	[Token(Token = "0x400482D")]
	[FieldOffset(Offset = "0x94")]
	public ParticleSystem SocialTeleportEffect;

	[Token(Token = "0x400482E")]
	[FieldOffset(Offset = "0x98")]
	public ParticleSystem BattleTeleportEffect;

	[Token(Token = "0x400482F")]
	[FieldOffset(Offset = "0x9C")]
	private ParticleSystem BODEOMMHFLE;

	[Token(Token = "0x4004830")]
	[FieldOffset(Offset = "0xA0")]
	private ParticleSystem JAJPHOECDDG;

	[Token(Token = "0x4004831")]
	[FieldOffset(Offset = "0xA4")]
	private ParticleSystem FLBCHCBAKOA;

	[Token(Token = "0x4004832")]
	[FieldOffset(Offset = "0xA8")]
	private bool LFNLJIKHHOO;

	[Token(Token = "0x600298C")]
	[Address(RVA = "0x20BCEA8", Offset = "0x20BCEA8", VA = "0x20BCEA8")]
	public LevelPortal()
	{
	}

	[Token(Token = "0x600298D")]
	[Address(RVA = "0x20BCEB0", Offset = "0x20BCEB0", VA = "0x20BCEB0", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x600298E")]
	[Address(RVA = "0x20BCF54", Offset = "0x20BCF54", VA = "0x20BCF54", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600298F")]
	[Address(RVA = "0x20BD5F4", Offset = "0x20BD5F4", VA = "0x20BD5F4", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002990")]
	[Address(RVA = "0x20BD87C", Offset = "0x20BD87C", VA = "0x20BD87C")]
	public void OnLocalPlayerEnterTrigger()
	{
	}

	[Token(Token = "0x6002991")]
	[Address(RVA = "0x20BDA88", Offset = "0x20BDA88", VA = "0x20BDA88")]
	public void OnLocalPlayerExitTrigger()
	{
	}

	[Token(Token = "0x6002992")]
	[Address(RVA = "0x20BD240", Offset = "0x20BD240", VA = "0x20BD240")]
	private void AGPEJMNIEDE(PDINOFLPCJG PHEJDNJONIL)
	{
	}

	[Token(Token = "0x6002993")]
	[Address(RVA = "0x20BDBA4", Offset = "0x20BDBA4", VA = "0x20BDBA4")]
	private void BEIJIIECKKI(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6002994")]
	[Address(RVA = "0x20BDDB8", Offset = "0x20BDDB8", VA = "0x20BDDB8")]
	private void GBAEHNHBAOH(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6002995")]
	[Address(RVA = "0x20BDE30", Offset = "0x20BDE30", VA = "0x20BDE30")]
	private void LNMLLFJOGOL(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6002996")]
	[Address(RVA = "0x20BDEB4", Offset = "0x20BDEB4", VA = "0x20BDEB4")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002997")]
	[Address(RVA = "0x20BDEBC", Offset = "0x20BDEBC", VA = "0x20BDEBC")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
