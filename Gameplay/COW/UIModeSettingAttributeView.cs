using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038B3")]
public class UIModeSettingAttributeView : UIBaseView
{
	[Token(Token = "0x4017736")]
	[FieldOffset(Offset = "0x14")]
	public UIButton AddBtn;

	[Token(Token = "0x4017737")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4017738")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList EasyGrid;

	[Token(Token = "0x4017739")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ScrollView;

	[Token(Token = "0x401773A")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Global;

	[Token(Token = "0x401773B")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Team;

	[Token(Token = "0x401773C")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton Player;

	[Token(Token = "0x401773D")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Empty;

	[Token(Token = "0x401773E")]
	[FieldOffset(Offset = "0x34")]
	public UILabel AddBtnLabel;

	[Token(Token = "0x401773F")]
	[FieldOffset(Offset = "0x38")]
	public UISprite AddBtnBg;

	[Token(Token = "0x4017740")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite BG;

	[Token(Token = "0x6016DC4")]
	[Address(RVA = "0x131AB68", Offset = "0x131AB68", VA = "0x131AB68")]
	public UIModeSettingAttributeView()
	{
	}

	[Token(Token = "0x6016DC5")]
	[Address(RVA = "0x131AB70", Offset = "0x131AB70", VA = "0x131AB70", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DC6")]
	[Address(RVA = "0x131B0CC", Offset = "0x131B0CC", VA = "0x131B0CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
