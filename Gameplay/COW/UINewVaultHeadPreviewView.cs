using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038CF")]
public class UINewVaultHeadPreviewView : UIBaseView
{
	[Token(Token = "0x40178AC")]
	[FieldOffset(Offset = "0x14")]
	public Transform PreviewPosNormal;

	[Token(Token = "0x40178AD")]
	[FieldOffset(Offset = "0x18")]
	public Transform PreviewPosPin;

	[Token(Token = "0x40178AE")]
	[FieldOffset(Offset = "0x1C")]
	public Transform profilePreview;

	[Token(Token = "0x40178AF")]
	[FieldOffset(Offset = "0x20")]
	public UILabel nickname;

	[Token(Token = "0x40178B0")]
	[FieldOffset(Offset = "0x24")]
	public GameObject fakebg;

	[Token(Token = "0x40178B1")]
	[FieldOffset(Offset = "0x28")]
	public UISprite briefbg;

	[Token(Token = "0x40178B2")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite IconBriefPin;

	[Token(Token = "0x40178B3")]
	[FieldOffset(Offset = "0x30")]
	public UISprite IconBigPin;

	[Token(Token = "0x6016E16")]
	[Address(RVA = "0x26C76D0", Offset = "0x26C76D0", VA = "0x26C76D0")]
	public UINewVaultHeadPreviewView()
	{
	}

	[Token(Token = "0x6016E17")]
	[Address(RVA = "0x26C76D8", Offset = "0x26C76D8", VA = "0x26C76D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E18")]
	[Address(RVA = "0x26C7A9C", Offset = "0x26C7A9C", VA = "0x26C7A9C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
