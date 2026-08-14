using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A2C")]
public class UIUGCHudEditListView : UIBaseView
{
	[Token(Token = "0x4018909")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CloseBtn;

	[Token(Token = "0x401890A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Panel;

	[Token(Token = "0x401890B")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton EditLayoutBtn;

	[Token(Token = "0x401890C")]
	[FieldOffset(Offset = "0x20")]
	public UIButton EditScriptBtn;

	[Token(Token = "0x401890D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel HudCount;

	[Token(Token = "0x401890E")]
	[FieldOffset(Offset = "0x28")]
	public UIButton AddBtn;

	[Token(Token = "0x401890F")]
	[FieldOffset(Offset = "0x2C")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4018910")]
	[FieldOffset(Offset = "0x30")]
	public UIEasyList Grid;

	[Token(Token = "0x4018911")]
	[FieldOffset(Offset = "0x34")]
	public GameObject HudInfo;

	[Token(Token = "0x4018912")]
	[FieldOffset(Offset = "0x38")]
	public GameObject NoHudTips;

	[Token(Token = "0x601722A")]
	[Address(RVA = "0x2FECBD4", Offset = "0x2FECBD4", VA = "0x2FECBD4")]
	public UIUGCHudEditListView()
	{
	}

	[Token(Token = "0x601722B")]
	[Address(RVA = "0x2FECBDC", Offset = "0x2FECBDC", VA = "0x2FECBDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601722C")]
	[Address(RVA = "0x2FED0CC", Offset = "0x2FED0CC", VA = "0x2FED0CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
