using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200339B")]
public class UIAccountDelPopupView : UIBaseView
{
	[Token(Token = "0x4013B05")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x4013B06")]
	[FieldOffset(Offset = "0x18")]
	public UIInput PasswordInput;

	[Token(Token = "0x4013B07")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Content;

	[Token(Token = "0x4013B08")]
	[FieldOffset(Offset = "0x20")]
	public UILabel URLLabel;

	[Token(Token = "0x4013B09")]
	[FieldOffset(Offset = "0x24")]
	public UIButton URLBtn;

	[Token(Token = "0x4013B0A")]
	[FieldOffset(Offset = "0x28")]
	public UIButton OKBtn;

	[Token(Token = "0x4013B0B")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel OKTxt;

	[Token(Token = "0x4013B0C")]
	[FieldOffset(Offset = "0x30")]
	public UIButton CancelBtn;

	[Token(Token = "0x4013B0D")]
	[FieldOffset(Offset = "0x34")]
	public UILabel CancelTxt;

	[Token(Token = "0x4013B0E")]
	[FieldOffset(Offset = "0x38")]
	public UIToggle Check;

	[Token(Token = "0x4013B0F")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Tips;

	[Token(Token = "0x6015E87")]
	[Address(RVA = "0x29FD494", Offset = "0x29FD494", VA = "0x29FD494")]
	public UIAccountDelPopupView()
	{
	}

	[Token(Token = "0x6015E88")]
	[Address(RVA = "0x29FD49C", Offset = "0x29FD49C", VA = "0x29FD49C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E89")]
	[Address(RVA = "0x29FDA04", Offset = "0x29FDA04", VA = "0x29FDA04")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
