using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200388B")]
public class UIMapDownloadSelectView : UIBaseView
{
	[Token(Token = "0x40175B2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnCancel;

	[Token(Token = "0x40175B3")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnComfirm;

	[Token(Token = "0x40175B4")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid MapList;

	[Token(Token = "0x6016D4C")]
	[Address(RVA = "0x2801734", Offset = "0x2801734", VA = "0x2801734")]
	public UIMapDownloadSelectView()
	{
	}

	[Token(Token = "0x6016D4D")]
	[Address(RVA = "0x280173C", Offset = "0x280173C", VA = "0x280173C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D4E")]
	[Address(RVA = "0x28019A4", Offset = "0x28019A4", VA = "0x28019A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
