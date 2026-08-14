using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A29")]
public class UIUGCDeleteFileSelectView : UIBaseView
{
	[Token(Token = "0x40188F2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnApply;

	[Token(Token = "0x40188F3")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnPublished;

	[Token(Token = "0x40188F4")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel PublishedDesc;

	[Token(Token = "0x40188F5")]
	[FieldOffset(Offset = "0x20")]
	public UILabel PublishedTime;

	[Token(Token = "0x40188F6")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnLocal;

	[Token(Token = "0x40188F7")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LocalDesc;

	[Token(Token = "0x40188F8")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LocalTime;

	[Token(Token = "0x40188F9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PublishSelected;

	[Token(Token = "0x40188FA")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LocalSelect;

	[Token(Token = "0x40188FB")]
	[FieldOffset(Offset = "0x38")]
	public GameObject WaningIcon;

	[Token(Token = "0x40188FC")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LocalWarningDesc;

	[Token(Token = "0x6017221")]
	[Address(RVA = "0x2B961D4", Offset = "0x2B961D4", VA = "0x2B961D4")]
	public UIUGCDeleteFileSelectView()
	{
	}

	[Token(Token = "0x6017222")]
	[Address(RVA = "0x2B961DC", Offset = "0x2B961DC", VA = "0x2B961DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017223")]
	[Address(RVA = "0x2B96714", Offset = "0x2B96714", VA = "0x2B96714")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
