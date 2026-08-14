using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033C8")]
public class UIAvatarLevelCardItemView : UIBaseView
{
	[Token(Token = "0x4013CC9")]
	[FieldOffset(Offset = "0x14")]
	public UIButton itemBtn;

	[Token(Token = "0x4013CCA")]
	[FieldOffset(Offset = "0x18")]
	public UISprite icon;

	[Token(Token = "0x4013CCB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject HL;

	[Token(Token = "0x4013CCC")]
	[FieldOffset(Offset = "0x20")]
	public UILabel cnt;

	[Token(Token = "0x4013CCD")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GraySprite;

	[Token(Token = "0x6015F0E")]
	[Address(RVA = "0x2A80B68", Offset = "0x2A80B68", VA = "0x2A80B68")]
	public UIAvatarLevelCardItemView()
	{
	}

	[Token(Token = "0x6015F0F")]
	[Address(RVA = "0x2A80B70", Offset = "0x2A80B70", VA = "0x2A80B70", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F10")]
	[Address(RVA = "0x2A80E80", Offset = "0x2A80E80", VA = "0x2A80E80")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
