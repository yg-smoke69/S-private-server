using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037C8")]
public class UIHudVehicleStatsView : UIBaseView
{
	[Token(Token = "0x4016984")]
	[FieldOffset(Offset = "0x14")]
	public Transform SpeedPointer;

	[Token(Token = "0x4016985")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelSpeed;

	[Token(Token = "0x4016986")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject HPNode;

	[Token(Token = "0x4016987")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HPIcon;

	[Token(Token = "0x4016988")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Effect_VFX;

	[Token(Token = "0x4016989")]
	[FieldOffset(Offset = "0x28")]
	public GameObject UpgradeNode;

	[Token(Token = "0x401698A")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Armor;

	[Token(Token = "0x401698B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Missile;

	[Token(Token = "0x401698C")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Boost;

	[Token(Token = "0x401698D")]
	[FieldOffset(Offset = "0x38")]
	public GameObject LV1;

	[Token(Token = "0x401698E")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LV2;

	[Token(Token = "0x401698F")]
	[FieldOffset(Offset = "0x40")]
	public GameObject LV3;

	[Token(Token = "0x4016990")]
	[FieldOffset(Offset = "0x44")]
	public GameObject LV4;

	[Token(Token = "0x6016B03")]
	[Address(RVA = "0x1A73160", Offset = "0x1A73160", VA = "0x1A73160")]
	public UIHudVehicleStatsView()
	{
	}

	[Token(Token = "0x6016B04")]
	[Address(RVA = "0x1A73168", Offset = "0x1A73168", VA = "0x1A73168", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B05")]
	[Address(RVA = "0x1A736F0", Offset = "0x1A736F0", VA = "0x1A736F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
