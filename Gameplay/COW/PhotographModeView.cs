using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200338E")]
public class PhotographModeView : UIBaseView
{
	[Token(Token = "0x4013A96")]
	[FieldOffset(Offset = "0x14")]
	public GameObject HideInShootScreen;

	[Token(Token = "0x4013A97")]
	[FieldOffset(Offset = "0x18")]
	public UISlider ScaleBar;

	[Token(Token = "0x4013A98")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton HideOthersBtn;

	[Token(Token = "0x4013A99")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HideOtherSprite;

	[Token(Token = "0x4013A9A")]
	[FieldOffset(Offset = "0x24")]
	public UIButton TakePhotoBtn;

	[Token(Token = "0x4013A9B")]
	[FieldOffset(Offset = "0x28")]
	public UIButton EmoteBtn;

	[Token(Token = "0x4013A9C")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton ExitBtn;

	[Token(Token = "0x4013A9D")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ShareShowUIRoot;

	[Token(Token = "0x6015E60")]
	[Address(RVA = "0x1C04F24", Offset = "0x1C04F24", VA = "0x1C04F24")]
	public PhotographModeView()
	{
	}

	[Token(Token = "0x6015E61")]
	[Address(RVA = "0x1C04F2C", Offset = "0x1C04F2C", VA = "0x1C04F2C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E62")]
	[Address(RVA = "0x1C0535C", Offset = "0x1C0535C", VA = "0x1C0535C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
