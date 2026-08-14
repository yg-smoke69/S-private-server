using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003951")]
public class UIRelationshipInvitePickWndView : UIBaseView
{
	[Token(Token = "0x4017FD4")]
	[FieldOffset(Offset = "0x14")]
	public GameObject NoneLabel;

	[Token(Token = "0x4017FD5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ScorllContainer;

	[Token(Token = "0x4017FD6")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NotFoundLabel;

	[Token(Token = "0x4017FD7")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SearchObj;

	[Token(Token = "0x4017FD8")]
	[FieldOffset(Offset = "0x24")]
	public UIInput SearchInput;

	[Token(Token = "0x4017FD9")]
	[FieldOffset(Offset = "0x28")]
	public TweenAlpha SearchTweenLabel;

	[Token(Token = "0x4017FDA")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton SearchBtn;

	[Token(Token = "0x4017FDB")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SearchBtnSprite;

	[Token(Token = "0x4017FDC")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SearchClearSprite;

	[Token(Token = "0x4017FDD")]
	[FieldOffset(Offset = "0x38")]
	public UIEasyList profileGrid;

	[Token(Token = "0x6016F9A")]
	[Address(RVA = "0x1E4DBD4", Offset = "0x1E4DBD4", VA = "0x1E4DBD4")]
	public UIRelationshipInvitePickWndView()
	{
	}

	[Token(Token = "0x6016F9B")]
	[Address(RVA = "0x1E4DBDC", Offset = "0x1E4DBDC", VA = "0x1E4DBDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F9C")]
	[Address(RVA = "0x1E4E0A8", Offset = "0x1E4E0A8", VA = "0x1E4E0A8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
