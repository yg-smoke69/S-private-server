using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200342E")]
public class UIChatMessageItemView : UIBaseView
{
	[Token(Token = "0x40142E7")]
	[FieldOffset(Offset = "0x14")]
	public BaseChatMessageView RightView;

	[Token(Token = "0x40142E8")]
	[FieldOffset(Offset = "0x18")]
	public UIButton headbtn;

	[Token(Token = "0x40142E9")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton RightContentBtn;

	[Token(Token = "0x40142EA")]
	[FieldOffset(Offset = "0x20")]
	public BaseChatMessageView LeftView;

	[Token(Token = "0x40142EB")]
	[FieldOffset(Offset = "0x24")]
	public UIButton headbtnleft;

	[Token(Token = "0x40142EC")]
	[FieldOffset(Offset = "0x28")]
	public UIButton LeftContentBtn;

	[Token(Token = "0x40142ED")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ChatTips;

	[Token(Token = "0x40142EE")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PrivateWarning;

	[Token(Token = "0x40142EF")]
	[FieldOffset(Offset = "0x34")]
	public GameObject AddFriendTip;

	[Token(Token = "0x40142F0")]
	[FieldOffset(Offset = "0x38")]
	public UILabel QuickAddFriendLabel;

	[Token(Token = "0x40142F1")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject AddFriendBtnContainer;

	[Token(Token = "0x40142F2")]
	[FieldOffset(Offset = "0x40")]
	public UIButton quickAddFriendBtn;

	[Token(Token = "0x40142F3")]
	[FieldOffset(Offset = "0x44")]
	public UISprite AddFriendBtnSprite;

	[Token(Token = "0x40142F4")]
	[FieldOffset(Offset = "0x48")]
	public UISprite AddFriendBtnIcon;

	[Token(Token = "0x40142F5")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite AddFriendBtnLight;

	[Token(Token = "0x601603E")]
	[Address(RVA = "0x20719F4", Offset = "0x20719F4", VA = "0x20719F4")]
	public UIChatMessageItemView()
	{
	}

	[Token(Token = "0x601603F")]
	[Address(RVA = "0x20719FC", Offset = "0x20719FC", VA = "0x20719FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016040")]
	[Address(RVA = "0x20720B4", Offset = "0x20720B4", VA = "0x20720B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
