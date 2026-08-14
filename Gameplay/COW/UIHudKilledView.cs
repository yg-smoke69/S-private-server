using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200368E")]
public class UIHudKilledView : UIBaseView
{
	[Token(Token = "0x4015F0A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Simple;

	[Token(Token = "0x4015F0B")]
	[FieldOffset(Offset = "0x18")]
	public UILabel content;

	[Token(Token = "0x4015F0C")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite KillerNameBG;

	[Token(Token = "0x4015F0D")]
	[FieldOffset(Offset = "0x20")]
	public UISprite KillTypeIcon;

	[Token(Token = "0x4015F0E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject General;

	[Token(Token = "0x4015F0F")]
	[FieldOffset(Offset = "0x28")]
	public Animator NormalKill;

	[Token(Token = "0x4015F10")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NormalKillGO;

	[Token(Token = "0x4015F11")]
	[FieldOffset(Offset = "0x30")]
	public Animator HeadShotKill;

	[Token(Token = "0x4015F12")]
	[FieldOffset(Offset = "0x34")]
	public GameObject HeadShotKillGO;

	[Token(Token = "0x4015F13")]
	[FieldOffset(Offset = "0x38")]
	public Animator Killed_AM_BlackBlood;

	[Token(Token = "0x4015F14")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Killed_AM_BlackBloodGO;

	[Token(Token = "0x4015F15")]
	[FieldOffset(Offset = "0x40")]
	public Animator Killed_AM_HeadShot_BlackBlood;

	[Token(Token = "0x4015F16")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Killed_AM_HeadShot_BlackBloodGO;

	[Token(Token = "0x4015F17")]
	[FieldOffset(Offset = "0x48")]
	public Animator Killed_KnockDown;

	[Token(Token = "0x4015F18")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Killed_KnockDownGO;

	[Token(Token = "0x4015F19")]
	[FieldOffset(Offset = "0x50")]
	public Animator Killed_Assist_KnockDown;

	[Token(Token = "0x4015F1A")]
	[FieldOffset(Offset = "0x54")]
	public GameObject Killed_AssistKnockDownGO;

	[Token(Token = "0x6016757")]
	[Address(RVA = "0x1BBD85C", Offset = "0x1BBD85C", VA = "0x1BBD85C")]
	public UIHudKilledView()
	{
	}

	[Token(Token = "0x6016758")]
	[Address(RVA = "0x1BBD864", Offset = "0x1BBD864", VA = "0x1BBD864", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016759")]
	[Address(RVA = "0x1BBDFAC", Offset = "0x1BBDFAC", VA = "0x1BBDFAC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
