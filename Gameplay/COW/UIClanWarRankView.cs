using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003468")]
public class UIClanWarRankView : UIBaseView
{
	[Token(Token = "0x40145CE")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButtonGroup RankToggleGroup;

	[Token(Token = "0x40145CF")]
	[FieldOffset(Offset = "0x18")]
	public UIToggleButton Team;

	[Token(Token = "0x40145D0")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton Player;

	[Token(Token = "0x40145D1")]
	[FieldOffset(Offset = "0x20")]
	public Transform Content;

	[Token(Token = "0x40145D2")]
	[FieldOffset(Offset = "0x24")]
	public UIScrollView ContentScrollView;

	[Token(Token = "0x40145D3")]
	[FieldOffset(Offset = "0x28")]
	public UIEasyList ContentList;

	[Token(Token = "0x40145D4")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject PersonRobbed;

	[Token(Token = "0x40145D5")]
	[FieldOffset(Offset = "0x30")]
	public GameObject TeamRobbed;

	[Token(Token = "0x40145D6")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SelfInfo;

	[Token(Token = "0x40145D7")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SelfBG;

	[Token(Token = "0x40145D8")]
	[FieldOffset(Offset = "0x3C")]
	public Transform SelfContainer;

	[Token(Token = "0x40145D9")]
	[FieldOffset(Offset = "0x40")]
	public UIButton ReturnBtn;

	[Token(Token = "0x60160EC")]
	[Address(RVA = "0x290823C", Offset = "0x290823C", VA = "0x290823C")]
	public UIClanWarRankView()
	{
	}

	[Token(Token = "0x60160ED")]
	[Address(RVA = "0x2908244", Offset = "0x2908244", VA = "0x2908244", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160EE")]
	[Address(RVA = "0x2908798", Offset = "0x2908798", VA = "0x2908798")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
