using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200345E")]
public class UIClanWarMarchMemberItemView : UIBaseView
{
	[Token(Token = "0x4014562")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4014563")]
	[FieldOffset(Offset = "0x18")]
	public Transform ProfileContent;

	[Token(Token = "0x4014564")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite HLCaptain;

	[Token(Token = "0x4014565")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HLSelf;

	[Token(Token = "0x4014566")]
	[FieldOffset(Offset = "0x24")]
	public UISprite HLReady;

	[Token(Token = "0x4014567")]
	[FieldOffset(Offset = "0x28")]
	public GameObject HLNewMember;

	[Token(Token = "0x4014568")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NotPresenceMask;

	[Token(Token = "0x60160CE")]
	[Address(RVA = "0x28F6FF4", Offset = "0x28F6FF4", VA = "0x28F6FF4")]
	public UIClanWarMarchMemberItemView()
	{
	}

	[Token(Token = "0x60160CF")]
	[Address(RVA = "0x28F6FFC", Offset = "0x28F6FFC", VA = "0x28F6FFC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160D0")]
	[Address(RVA = "0x28F73A4", Offset = "0x28F73A4", VA = "0x28F73A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
