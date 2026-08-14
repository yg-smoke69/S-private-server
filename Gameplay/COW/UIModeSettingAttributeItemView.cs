using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038B2")]
public class UIModeSettingAttributeItemView : UIBaseView
{
	[Token(Token = "0x401772F")]
	[FieldOffset(Offset = "0x14")]
	public Transform attribute;

	[Token(Token = "0x4017730")]
	[FieldOffset(Offset = "0x18")]
	public UIInput ValueInput;

	[Token(Token = "0x4017731")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput NameInput;

	[Token(Token = "0x4017732")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Standardvalue;

	[Token(Token = "0x4017733")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BoolValue;

	[Token(Token = "0x4017734")]
	[FieldOffset(Offset = "0x28")]
	public UIButton DeleteBtn;

	[Token(Token = "0x4017735")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite bg;

	[Token(Token = "0x6016DC1")]
	[Address(RVA = "0x131A7B0", Offset = "0x131A7B0", VA = "0x131A7B0")]
	public UIModeSettingAttributeItemView()
	{
	}

	[Token(Token = "0x6016DC2")]
	[Address(RVA = "0x131A7B8", Offset = "0x131A7B8", VA = "0x131A7B8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DC3")]
	[Address(RVA = "0x131AB60", Offset = "0x131AB60", VA = "0x131AB60")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
