using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037E9")]
public class UIHudWolfTaskView : UIBaseView
{
	[Token(Token = "0x4016ADB")]
	[FieldOffset(Offset = "0x14")]
	public UIButton WolfTaskBtn1;

	[Token(Token = "0x4016ADC")]
	[FieldOffset(Offset = "0x18")]
	public UISprite WolfTaskBtnSprite1;

	[Token(Token = "0x4016ADD")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton WolfTaskBtn2;

	[Token(Token = "0x4016ADE")]
	[FieldOffset(Offset = "0x20")]
	public UISprite WolfTaskBtnSprite2;

	[Token(Token = "0x4016ADF")]
	[FieldOffset(Offset = "0x24")]
	public UIButton WolfTaskBtn3;

	[Token(Token = "0x4016AE0")]
	[FieldOffset(Offset = "0x28")]
	public UISprite WolfTaskBtnSprite3;

	[Token(Token = "0x4016AE1")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton WolfTaskBtnAll;

	[Token(Token = "0x4016AE2")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SpriteBtnTask;

	[Token(Token = "0x4016AE3")]
	[FieldOffset(Offset = "0x34")]
	public UISprite WolfTaskMask;

	[Token(Token = "0x4016AE4")]
	[FieldOffset(Offset = "0x38")]
	public UILabel CoolDownLabel;

	[Token(Token = "0x6016B66")]
	[Address(RVA = "0x2943E60", Offset = "0x2943E60", VA = "0x2943E60")]
	public UIHudWolfTaskView()
	{
	}

	[Token(Token = "0x6016B67")]
	[Address(RVA = "0x2943E68", Offset = "0x2943E68", VA = "0x2943E68", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B68")]
	[Address(RVA = "0x2944370", Offset = "0x2944370", VA = "0x2944370")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
