using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200375B")]
public class UIHudSpeedupAreaView : UIBaseView
{
	[Token(Token = "0x4016669")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SpeedupArea;

	[Token(Token = "0x401666A")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget AreaWgt;

	[Token(Token = "0x401666B")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton btnSpeedup;

	[Token(Token = "0x401666C")]
	[FieldOffset(Offset = "0x20")]
	public UISprite icon;

	[Token(Token = "0x401666D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ActionNameTxt;

	[Token(Token = "0x401666E")]
	[FieldOffset(Offset = "0x28")]
	public UISprite CDProgress;

	[Token(Token = "0x401666F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject CDMask;

	[Token(Token = "0x4016670")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Bg;

	[Token(Token = "0x60169BC")]
	[Address(RVA = "0x1FE8000", Offset = "0x1FE8000", VA = "0x1FE8000")]
	public UIHudSpeedupAreaView()
	{
	}

	[Token(Token = "0x60169BD")]
	[Address(RVA = "0x1FE8008", Offset = "0x1FE8008", VA = "0x1FE8008", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169BE")]
	[Address(RVA = "0x1FE8438", Offset = "0x1FE8438", VA = "0x1FE8438")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
