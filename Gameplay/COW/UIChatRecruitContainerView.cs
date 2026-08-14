using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003430")]
public class UIChatRecruitContainerView : UIBaseView
{
	[Token(Token = "0x40142F7")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Widget;

	[Token(Token = "0x40142F8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ContentNode;

	[Token(Token = "0x40142F9")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView MessageList;

	[Token(Token = "0x40142FA")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList MessageEasyList;

	[Token(Token = "0x40142FB")]
	[FieldOffset(Offset = "0x24")]
	public GameObject EmptyNode;

	[Token(Token = "0x40142FC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NoMessageHint;

	[Token(Token = "0x40142FD")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NoGroupNode;

	[Token(Token = "0x40142FE")]
	[FieldOffset(Offset = "0x30")]
	public UIButton RecruitBtnNoGroup;

	[Token(Token = "0x40142FF")]
	[FieldOffset(Offset = "0x34")]
	public GameObject InGroupNode;

	[Token(Token = "0x4014300")]
	[FieldOffset(Offset = "0x38")]
	public UIButton RecruitBtnInGroup;

	[Token(Token = "0x4014301")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite GroupModeIcon;

	[Token(Token = "0x4014302")]
	[FieldOffset(Offset = "0x40")]
	public UILabel GameMode;

	[Token(Token = "0x4014303")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Map;

	[Token(Token = "0x4014304")]
	[FieldOffset(Offset = "0x48")]
	public UISprite LadderIcon;

	[Token(Token = "0x4014305")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton LeaveGroupBtn;

	[Token(Token = "0x6016044")]
	[Address(RVA = "0x2075D30", Offset = "0x2075D30", VA = "0x2075D30")]
	public UIChatRecruitContainerView()
	{
	}

	[Token(Token = "0x6016045")]
	[Address(RVA = "0x2075D38", Offset = "0x2075D38", VA = "0x2075D38", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016046")]
	[Address(RVA = "0x20763E4", Offset = "0x20763E4", VA = "0x20763E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
