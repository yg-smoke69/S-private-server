using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000674")]
public class LevelPartyMusicBeatZone : BaseLevelObject, _Attribute
{
	[Token(Token = "0x40047E6")]
	[FieldOffset(Offset = "0x74")]
	public string BeatsConfig;

	[Token(Token = "0x40047E7")]
	[FieldOffset(Offset = "0x78")]
	public string EffectConfig;

	[Token(Token = "0x40047E8")]
	[FieldOffset(Offset = "0x7C")]
	public string AnimConfig;

	[Token(Token = "0x40047E9")]
	[FieldOffset(Offset = "0x80")]
	public Collider TriggerCollider;

	[Token(Token = "0x40047EA")]
	[FieldOffset(Offset = "0x84")]
	private Dictionary<uint, PartyBeatEffectData> KPAPEHBIFCN;

	[Token(Token = "0x40047EB")]
	[FieldOffset(Offset = "0x88")]
	private List<PartyDanceAnimData> BGLHMLLEIFH;

	[Token(Token = "0x40047EC")]
	[FieldOffset(Offset = "0x8C")]
	private float KMHEPNNMNOH;

	[Token(Token = "0x40047ED")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<PartyDanceAnimData> HMDOHFBHDOB;

	[Token(Token = "0x6002930")]
	[Address(RVA = "0x20B7730", Offset = "0x20B7730", VA = "0x20B7730")]
	public LevelPartyMusicBeatZone()
	{
	}

	[Token(Token = "0x6002931")]
	[Address(RVA = "0x20B77C8", Offset = "0x20B77C8", VA = "0x20B77C8", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002932")]
	[Address(RVA = "0x20B7DF0", Offset = "0x20B7DF0", VA = "0x20B7DF0", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002933")]
	[Address(RVA = "0x20B7E94", Offset = "0x20B7E94", VA = "0x20B7E94", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002934")]
	[Address(RVA = "0x20B80D4", Offset = "0x20B80D4", VA = "0x20B80D4", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002935")]
	[Address(RVA = "0x20B8194", Offset = "0x20B8194", VA = "0x20B8194")]
	private void CELEJLOCCMF()
	{
	}

	[Token(Token = "0x6002936")]
	[Address(RVA = "0x20B8810", Offset = "0x20B8810", VA = "0x20B8810")]
	public void SetZoneEnable(bool MCDIDHODHLN)
	{
	}

	[Token(Token = "0x6002937")]
	[Address(RVA = "0x20B89D4", Offset = "0x20B89D4", VA = "0x20B89D4", Slot = "42")]
	private void COW_002EGamePlay_002EILevelMusicBeat_002EOnTapAtBeat(bool LALPBHKBKDH)
	{
	}

	[Token(Token = "0x6002938")]
	[Address(RVA = "0x20B8A30", Offset = "0x20B8A30", VA = "0x20B8A30", Slot = "43")]
	private void COW_002EGamePlay_002EILevelMusicBeat_002EOnComboTap(int BJHEDKLAFCO)
	{
	}

	[Token(Token = "0x6002939")]
	[Address(RVA = "0x20B8D38", Offset = "0x20B8D38", VA = "0x20B8D38", Slot = "44")]
	private void COW_002EGamePlay_002EILevelMusicBeat_002EOnInterruptCombo()
	{
	}

	[Token(Token = "0x600293A")]
	[Address(RVA = "0x20B8FDC", Offset = "0x20B8FDC", VA = "0x20B8FDC", Slot = "45")]
	private ResourceID COW_002EGamePlay_002EILevelMusicBeat_002EGetBeatListResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600293B")]
	[Address(RVA = "0x20B908C", Offset = "0x20B908C", VA = "0x20B908C", Slot = "40")]
	private void COW_002EGamePlay_002EILevelMusicBeat_002EOnStartMusicBeat()
	{
	}

	[Token(Token = "0x600293C")]
	[Address(RVA = "0x20B91FC", Offset = "0x20B91FC", VA = "0x20B91FC", Slot = "41")]
	private void COW_002EGamePlay_002EILevelMusicBeat_002EOnStopMusicBeat()
	{
	}

	[Token(Token = "0x600293D")]
	[Address(RVA = "0x20B94F0", Offset = "0x20B94F0", VA = "0x20B94F0", Slot = "46")]
	private ResourceID COW_002EGamePlay_002EILevelMusicBeat_002EGetBeatLevelEffectResID(uint EIKCFIDCCMM)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600293E")]
	[Address(RVA = "0x20B962C", Offset = "0x20B962C", VA = "0x20B962C")]
	private static int HGFEPADDDOG(PartyDanceAnimData NHJNFPKBBLI, PartyDanceAnimData LGALHNNDGNE)
	{
		return default(int);
	}

	[Token(Token = "0x600293F")]
	[Address(RVA = "0x20B9674", Offset = "0x20B9674", VA = "0x20B9674")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002940")]
	[Address(RVA = "0x20B967C", Offset = "0x20B967C", VA = "0x20B967C")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	[Token(Token = "0x6002941")]
	[Address(RVA = "0x20B9684", Offset = "0x20B9684", VA = "0x20B9684")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
