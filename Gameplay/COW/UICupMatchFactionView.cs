using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003497")]
public class UICupMatchFactionView : UIBaseView
{
	[Token(Token = "0x401482B")]
	[FieldOffset(Offset = "0x14")]
	public Animator Animator;

	[Token(Token = "0x401482C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel MyTeamName;

	[Token(Token = "0x401482D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel MyTeamDesc;

	[Token(Token = "0x401482E")]
	[FieldOffset(Offset = "0x20")]
	public UISprite MyTeamIcon;

	[Token(Token = "0x401482F")]
	[FieldOffset(Offset = "0x24")]
	public UILabel OppoTeamName;

	[Token(Token = "0x4014830")]
	[FieldOffset(Offset = "0x28")]
	public UILabel OppoTeamDesc;

	[Token(Token = "0x4014831")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite OppoTeamIcon;

	[Token(Token = "0x4014832")]
	[FieldOffset(Offset = "0x30")]
	public UIButton MaskBtn;

	[Token(Token = "0x4014833")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Next;

	[Token(Token = "0x6016179")]
	[Address(RVA = "0x2AA2EE8", Offset = "0x2AA2EE8", VA = "0x2AA2EE8")]
	public UICupMatchFactionView()
	{
	}

	[Token(Token = "0x601617A")]
	[Address(RVA = "0x2AA2EF0", Offset = "0x2AA2EF0", VA = "0x2AA2EF0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601617B")]
	[Address(RVA = "0x2AA3398", Offset = "0x2AA3398", VA = "0x2AA3398")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
