using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035B1")]
public class UIGiftLeaderBoardView : UIBaseView
{
	[Token(Token = "0x4015742")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4015743")]
	[FieldOffset(Offset = "0x18")]
	public UICountDownLabel LeftTime;

	[Token(Token = "0x4015744")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton ReceiverToggle;

	[Token(Token = "0x4015745")]
	[FieldOffset(Offset = "0x20")]
	public UIToggleButton GiverToggle;

	[Token(Token = "0x4015746")]
	[FieldOffset(Offset = "0x24")]
	public UIScrollView ContentScrollView;

	[Token(Token = "0x4015747")]
	[FieldOffset(Offset = "0x28")]
	public UIEasyList Grid;

	[Token(Token = "0x4015748")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel title;

	[Token(Token = "0x4015749")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnClose;

	[Token(Token = "0x401574A")]
	[FieldOffset(Offset = "0x34")]
	public GameObject PlayerListTitleBar;

	[Token(Token = "0x401574B")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Count;

	[Token(Token = "0x401574C")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite GiftIcon;

	[Token(Token = "0x401574D")]
	[FieldOffset(Offset = "0x40")]
	public UIEasyList RewardsGrid;

	[Token(Token = "0x401574E")]
	[FieldOffset(Offset = "0x44")]
	public GameObject SelfInfo;

	[Token(Token = "0x401574F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject BaseProfile;

	[Token(Token = "0x60164C1")]
	[Address(RVA = "0x1CEC894", Offset = "0x1CEC894", VA = "0x1CEC894")]
	public UIGiftLeaderBoardView()
	{
	}

	[Token(Token = "0x60164C2")]
	[Address(RVA = "0x1CEC89C", Offset = "0x1CEC89C", VA = "0x1CEC89C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164C3")]
	[Address(RVA = "0x1CECF00", Offset = "0x1CECF00", VA = "0x1CECF00")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
