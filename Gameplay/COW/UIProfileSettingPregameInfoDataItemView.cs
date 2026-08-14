using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200392E")]
public class UIProfileSettingPregameInfoDataItemView : UIBaseView
{
	[Token(Token = "0x4017DDB")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelTitle;

	[Token(Token = "0x4017DDC")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelValue;

	[Token(Token = "0x4017DDD")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteBg;

	[Token(Token = "0x4017DDE")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteToggleBg;

	[Token(Token = "0x4017DDF")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteSelect;

	[Token(Token = "0x4017DE0")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Btn;

	[Token(Token = "0x4017DE1")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget WidgetBtn;

	[Token(Token = "0x6016F31")]
	[Address(RVA = "0x1AB4508", Offset = "0x1AB4508", VA = "0x1AB4508")]
	public UIProfileSettingPregameInfoDataItemView()
	{
	}

	[Token(Token = "0x6016F32")]
	[Address(RVA = "0x1AB4510", Offset = "0x1AB4510", VA = "0x1AB4510", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F33")]
	[Address(RVA = "0x1AB48F8", Offset = "0x1AB48F8", VA = "0x1AB48F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
