using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200368B")]
public class UIHudJumpView : UIBaseView
{
	[Token(Token = "0x4015EEF")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BGJump;

	[Token(Token = "0x4015EF0")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Effect_VFX;

	[Token(Token = "0x4015EF1")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnJump;

	[Token(Token = "0x4015EF2")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BtnSprite;

	[Token(Token = "0x4015EF3")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Energy;

	[Token(Token = "0x4015EF4")]
	[FieldOffset(Offset = "0x28")]
	public UISprite EnergyBar;

	[Token(Token = "0x4015EF5")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite EnergyBarHL;

	[Token(Token = "0x601674E")]
	[Address(RVA = "0x20B4354", Offset = "0x20B4354", VA = "0x20B4354")]
	public UIHudJumpView()
	{
	}

	[Token(Token = "0x601674F")]
	[Address(RVA = "0x20B435C", Offset = "0x20B435C", VA = "0x20B435C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016750")]
	[Address(RVA = "0x20B472C", Offset = "0x20B472C", VA = "0x20B472C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
