using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033B8")]
public class UIActivityStandardContentView : UIBaseView
{
	[Token(Token = "0x4013C0C")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ScrollView_NoTabs;

	[Token(Token = "0x4013C0D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ScrollView;

	[Token(Token = "0x4013C0E")]
	[FieldOffset(Offset = "0x1C")]
	public UITable ContentTable;

	[Token(Token = "0x4013C0F")]
	[FieldOffset(Offset = "0x20")]
	public ActivityAwardDescription AwardDescTemplate;

	[Token(Token = "0x4013C10")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Gained;

	[Token(Token = "0x4013C11")]
	[FieldOffset(Offset = "0x28")]
	public UILabel GainedLabel;

	[Token(Token = "0x4013C12")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Title;

	[Token(Token = "0x4013C13")]
	[FieldOffset(Offset = "0x30")]
	public UIDragScrollView DragArea;

	[Token(Token = "0x6015EDE")]
	[Address(RVA = "0x1F227EC", Offset = "0x1F227EC", VA = "0x1F227EC")]
	public UIActivityStandardContentView()
	{
	}

	[Token(Token = "0x6015EDF")]
	[Address(RVA = "0x1F227F4", Offset = "0x1F227F4", VA = "0x1F227F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EE0")]
	[Address(RVA = "0x1F22C0C", Offset = "0x1F22C0C", VA = "0x1F22C0C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
