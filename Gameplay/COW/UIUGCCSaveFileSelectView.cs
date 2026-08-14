using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A25")]
public class UIUGCCSaveFileSelectView : UIBaseView
{
	[Token(Token = "0x40188D2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnApply;

	[Token(Token = "0x40188D3")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnPublished;

	[Token(Token = "0x40188D4")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel PublishedDesc;

	[Token(Token = "0x40188D5")]
	[FieldOffset(Offset = "0x20")]
	public UILabel PublishedTime;

	[Token(Token = "0x40188D6")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnLocal;

	[Token(Token = "0x40188D7")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LocalDesc;

	[Token(Token = "0x40188D8")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LocalTime;

	[Token(Token = "0x40188D9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PublishSelected;

	[Token(Token = "0x40188DA")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LocalSelect;

	[Token(Token = "0x40188DB")]
	[FieldOffset(Offset = "0x38")]
	public GameObject WaningIcon;

	[Token(Token = "0x40188DC")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LocalWarningDesc;

	[Token(Token = "0x6017215")]
	[Address(RVA = "0x2B80774", Offset = "0x2B80774", VA = "0x2B80774")]
	public UIUGCCSaveFileSelectView()
	{
	}

	[Token(Token = "0x6017216")]
	[Address(RVA = "0x2B8077C", Offset = "0x2B8077C", VA = "0x2B8077C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017217")]
	[Address(RVA = "0x2B80CB4", Offset = "0x2B80CB4", VA = "0x2B80CB4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
