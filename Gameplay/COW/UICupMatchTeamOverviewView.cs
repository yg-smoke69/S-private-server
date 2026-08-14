using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034A9")]
public class UICupMatchTeamOverviewView : UIBaseView
{
	[Token(Token = "0x40148EA")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x40148EB")]
	[FieldOffset(Offset = "0x18")]
	public UISprite TeamIcon;

	[Token(Token = "0x40148EC")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton TeamIconBtn;

	[Token(Token = "0x40148ED")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TeamName;

	[Token(Token = "0x40148EE")]
	[FieldOffset(Offset = "0x24")]
	public GameObject FlagBg;

	[Token(Token = "0x40148EF")]
	[FieldOffset(Offset = "0x28")]
	public UISprite NationFlag;

	[Token(Token = "0x40148F0")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton InfoEdit;

	[Token(Token = "0x40148F1")]
	[FieldOffset(Offset = "0x30")]
	public UIButton InfoEdit_bg;

	[Token(Token = "0x40148F2")]
	[FieldOffset(Offset = "0x34")]
	public UIButton TeamTier;

	[Token(Token = "0x40148F3")]
	[FieldOffset(Offset = "0x38")]
	public UILabel TierLevel;

	[Token(Token = "0x40148F4")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject NoTeamIcon;

	[Token(Token = "0x60161AF")]
	[Address(RVA = "0x11DFB34", Offset = "0x11DFB34", VA = "0x11DFB34")]
	public UICupMatchTeamOverviewView()
	{
	}

	[Token(Token = "0x60161B0")]
	[Address(RVA = "0x11DFB3C", Offset = "0x11DFB3C", VA = "0x11DFB3C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161B1")]
	[Address(RVA = "0x11E0080", Offset = "0x11E0080", VA = "0x11E0080")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
