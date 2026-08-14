using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039F4")]
public class UIStandardTopTabView : UIBaseView
{
	[Token(Token = "0x40186BE")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel TabPanel;

	[Token(Token = "0x40186BF")]
	[FieldOffset(Offset = "0x18")]
	public UIButton leaveBtn;

	[Token(Token = "0x40186C0")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BG;

	[Token(Token = "0x40186C1")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40186C2")]
	[FieldOffset(Offset = "0x24")]
	public UIEasyList EasyList;

	[Token(Token = "0x6017182")]
	[Address(RVA = "0x20075FC", Offset = "0x20075FC", VA = "0x20075FC")]
	public UIStandardTopTabView()
	{
	}

	[Token(Token = "0x6017183")]
	[Address(RVA = "0x2007604", Offset = "0x2007604", VA = "0x2007604", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017184")]
	[Address(RVA = "0x200792C", Offset = "0x200792C", VA = "0x200792C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
