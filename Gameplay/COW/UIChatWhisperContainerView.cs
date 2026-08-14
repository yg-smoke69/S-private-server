using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003437")]
public class UIChatWhisperContainerView : UIBaseView
{
	[Token(Token = "0x4014369")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Widget;

	[Token(Token = "0x401436A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ContentNode;

	[Token(Token = "0x401436B")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView WhisperMessageList;

	[Token(Token = "0x401436C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject EmptyNode;

	[Token(Token = "0x401436D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject NoMessageHint;

	[Token(Token = "0x401436E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NoWhisperObjcetHint;

	[Token(Token = "0x401436F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject TopMessage;

	[Token(Token = "0x4014370")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ChatWith;

	[Token(Token = "0x4014371")]
	[FieldOffset(Offset = "0x34")]
	public UIButton SendGift;

	[Token(Token = "0x4014372")]
	[FieldOffset(Offset = "0x38")]
	public UIButton Profile;

	[Token(Token = "0x4014373")]
	[FieldOffset(Offset = "0x3C")]
	public UIDragScrollView WhisperNameListDrag;

	[Token(Token = "0x4014374")]
	[FieldOffset(Offset = "0x40")]
	public UIScrollView WhisperNameListSV;

	[Token(Token = "0x4014375")]
	[FieldOffset(Offset = "0x44")]
	public UIEasyList WhisperNameEasyList;

	[Token(Token = "0x4014376")]
	[FieldOffset(Offset = "0x48")]
	public UIScrollView WhisperNameListRecentSV;

	[Token(Token = "0x4014377")]
	[FieldOffset(Offset = "0x4C")]
	public UIEasyList WhisperNameRecentEasyList;

	[Token(Token = "0x4014378")]
	[FieldOffset(Offset = "0x50")]
	public UIButton AddFriendBtn;

	[Token(Token = "0x4014379")]
	[FieldOffset(Offset = "0x54")]
	public GameObject NoRecentWhisperGO;

	[Token(Token = "0x401437A")]
	[FieldOffset(Offset = "0x58")]
	public UIToggleButton FriendTabBtn;

	[Token(Token = "0x401437B")]
	[FieldOffset(Offset = "0x5C")]
	public UIToggleButton RecentTabBtn;

	[Token(Token = "0x401437C")]
	[FieldOffset(Offset = "0x60")]
	public GameObject UnreadTip;

	[Token(Token = "0x401437D")]
	[FieldOffset(Offset = "0x64")]
	public GameObject SearchGO;

	[Token(Token = "0x401437E")]
	[FieldOffset(Offset = "0x68")]
	public UIButton RefreshBtn;

	[Token(Token = "0x401437F")]
	[FieldOffset(Offset = "0x6C")]
	public UIInput InputIDField;

	[Token(Token = "0x4014380")]
	[FieldOffset(Offset = "0x70")]
	public TweenAlpha DefaultLabelWink;

	[Token(Token = "0x4014381")]
	[FieldOffset(Offset = "0x74")]
	public UIButton SearchBtn;

	[Token(Token = "0x4014382")]
	[FieldOffset(Offset = "0x78")]
	public GameObject SearchBtnSprite;

	[Token(Token = "0x4014383")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject SearchClearSprite;

	[Token(Token = "0x6016059")]
	[Address(RVA = "0x208502C", Offset = "0x208502C", VA = "0x208502C")]
	public UIChatWhisperContainerView()
	{
	}

	[Token(Token = "0x601605A")]
	[Address(RVA = "0x2085034", Offset = "0x2085034", VA = "0x2085034", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601605B")]
	[Address(RVA = "0x2085B24", Offset = "0x2085B24", VA = "0x2085B24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
