using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003502")]
public class UIElitePassDocumentItemView : UIBaseView
{
	[Token(Token = "0x4014E20")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelEPId;

	[Token(Token = "0x4014E21")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelEPId2;

	[Token(Token = "0x4014E22")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture EPTexture;

	[Token(Token = "0x4014E23")]
	[FieldOffset(Offset = "0x20")]
	public UISprite EPBadge;

	[Token(Token = "0x4014E24")]
	[FieldOffset(Offset = "0x24")]
	public UILabel EPBadgeNum;

	[Token(Token = "0x4014E25")]
	[FieldOffset(Offset = "0x28")]
	public GameObject VFX_Effect;

	[Token(Token = "0x60162B6")]
	[Address(RVA = "0x2A56938", Offset = "0x2A56938", VA = "0x2A56938")]
	public UIElitePassDocumentItemView()
	{
	}

	[Token(Token = "0x60162B7")]
	[Address(RVA = "0x2A56940", Offset = "0x2A56940", VA = "0x2A56940", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162B8")]
	[Address(RVA = "0x2A56CBC", Offset = "0x2A56CBC", VA = "0x2A56CBC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
