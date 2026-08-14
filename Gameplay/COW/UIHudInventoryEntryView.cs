using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200367D")]
public class UIHudInventoryEntryView : UIBaseView
{
	[Token(Token = "0x4015E3A")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnInventory;

	[Token(Token = "0x4015E3B")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem FlashEffect;

	[Token(Token = "0x4015E3C")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Capratio;

	[Token(Token = "0x4015E3D")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteBg;

	[Token(Token = "0x4015E3E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel CapacityRatio;

	[Token(Token = "0x4015E3F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject MaxCap;

	[Token(Token = "0x4015E40")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ItemLevelInfo;

	[Token(Token = "0x4015E41")]
	[FieldOffset(Offset = "0x30")]
	public GameObject VFX_richer;

	[Token(Token = "0x6016724")]
	[Address(RVA = "0x2097340", Offset = "0x2097340", VA = "0x2097340")]
	public UIHudInventoryEntryView()
	{
	}

	[Token(Token = "0x6016725")]
	[Address(RVA = "0x2097348", Offset = "0x2097348", VA = "0x2097348", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016726")]
	[Address(RVA = "0x2097778", Offset = "0x2097778", VA = "0x2097778")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
