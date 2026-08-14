using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003727")]
public class UIHudSceneEditCodeSearchView : UIBaseView
{
	[Token(Token = "0x40164B7")]
	[FieldOffset(Offset = "0x14")]
	public GameObject InfoPanel;

	[Token(Token = "0x40164B8")]
	[FieldOffset(Offset = "0x18")]
	public UISceneEditSlotInfoView SlotInfoView;

	[Token(Token = "0x40164B9")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject MapIcon;

	[Token(Token = "0x40164BA")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture CDNMap;

	[Token(Token = "0x40164BB")]
	[FieldOffset(Offset = "0x24")]
	public UILabel CodeTxt;

	[Token(Token = "0x40164BC")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid InfoGrid;

	[Token(Token = "0x40164BD")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnReport;

	[Token(Token = "0x40164BE")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnPreview;

	[Token(Token = "0x40164BF")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnSubscribe;

	[Token(Token = "0x40164C0")]
	[FieldOffset(Offset = "0x38")]
	public GameObject GMPreview;

	[Token(Token = "0x40164C1")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnGMVerifyLast;

	[Token(Token = "0x40164C2")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnGMVerifyNext;

	[Token(Token = "0x40164C3")]
	[FieldOffset(Offset = "0x44")]
	public UILabel GMExaminationResultTxt;

	[Token(Token = "0x6016920")]
	[Address(RVA = "0x1C56B4C", Offset = "0x1C56B4C", VA = "0x1C56B4C")]
	public UIHudSceneEditCodeSearchView()
	{
	}

	[Token(Token = "0x6016921")]
	[Address(RVA = "0x1C56B54", Offset = "0x1C56B54", VA = "0x1C56B54", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016922")]
	[Address(RVA = "0x1C57158", Offset = "0x1C57158", VA = "0x1C57158")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
