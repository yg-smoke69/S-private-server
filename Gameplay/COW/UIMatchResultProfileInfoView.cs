using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003895")]
public class UIMatchResultProfileInfoView : UIBaseView
{
	[Token(Token = "0x4017602")]
	[FieldOffset(Offset = "0x14")]
	public Animator UIMatchResultProfileInfo;

	[Token(Token = "0x4017603")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SelfBG;

	[Token(Token = "0x4017604")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NormalBG;

	[Token(Token = "0x4017605")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget Tag;

	[Token(Token = "0x4017606")]
	[FieldOffset(Offset = "0x24")]
	public GameObject TagItem;

	[Token(Token = "0x4017607")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TagGo;

	[Token(Token = "0x4017608")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TagNum;

	[Token(Token = "0x4017609")]
	[FieldOffset(Offset = "0x30")]
	public UILabel PlayerNameTxt;

	[Token(Token = "0x401760A")]
	[FieldOffset(Offset = "0x34")]
	public GameObject IconCelebrity;

	[Token(Token = "0x401760B")]
	[FieldOffset(Offset = "0x38")]
	public UILabel KillTitle;

	[Token(Token = "0x401760C")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel KillNumTxt;

	[Token(Token = "0x401760D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel DamageTitle;

	[Token(Token = "0x401760E")]
	[FieldOffset(Offset = "0x44")]
	public UILabel DamageNumTxt;

	[Token(Token = "0x401760F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject MVPFlag;

	[Token(Token = "0x4017610")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject WinMVPGrade;

	[Token(Token = "0x4017611")]
	[FieldOffset(Offset = "0x50")]
	public GameObject FailMVPGrade;

	[Token(Token = "0x6016D6A")]
	[Address(RVA = "0x28191EC", Offset = "0x28191EC", VA = "0x28191EC")]
	public UIMatchResultProfileInfoView()
	{
	}

	[Token(Token = "0x6016D6B")]
	[Address(RVA = "0x28191F4", Offset = "0x28191F4", VA = "0x28191F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D6C")]
	[Address(RVA = "0x28198DC", Offset = "0x28198DC", VA = "0x28198DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
