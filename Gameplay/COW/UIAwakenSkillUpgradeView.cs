using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033E2")]
public class UIAwakenSkillUpgradeView : UIBaseView
{
	[Token(Token = "0x4013EE1")]
	[FieldOffset(Offset = "0x14")]
	public UILabel SkillDesc;

	[Token(Token = "0x4013EE2")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SkillName;

	[Token(Token = "0x4013EE3")]
	[FieldOffset(Offset = "0x1C")]
	public Transform SkillSlotContainer;

	[Token(Token = "0x4013EE4")]
	[FieldOffset(Offset = "0x20")]
	public UILabel NextLvDesc;

	[Token(Token = "0x4013EE5")]
	[FieldOffset(Offset = "0x24")]
	public UISprite DebrisSpri;

	[Token(Token = "0x4013EE6")]
	[FieldOffset(Offset = "0x28")]
	public UILabel DebrisCnt;

	[Token(Token = "0x4013EE7")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ConsumeItemSpri;

	[Token(Token = "0x4013EE8")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ConsumeItemCnt;

	[Token(Token = "0x4013EE9")]
	[FieldOffset(Offset = "0x34")]
	public UIButton UpgradeBtn;

	[Token(Token = "0x6015F5C")]
	[Address(RVA = "0x14006F4", Offset = "0x14006F4", VA = "0x14006F4")]
	public UIAwakenSkillUpgradeView()
	{
	}

	[Token(Token = "0x6015F5D")]
	[Address(RVA = "0x14006FC", Offset = "0x14006FC", VA = "0x14006FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F5E")]
	[Address(RVA = "0x1400B7C", Offset = "0x1400B7C", VA = "0x1400B7C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
