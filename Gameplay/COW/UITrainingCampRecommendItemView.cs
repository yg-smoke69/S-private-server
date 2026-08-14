using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A0C")]
public class UITrainingCampRecommendItemView : UIBaseView
{
	[Token(Token = "0x40187CD")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ProfilePos;

	[Token(Token = "0x40187CE")]
	[FieldOffset(Offset = "0x18")]
	public UIButton InviteBtn;

	[Token(Token = "0x40187CF")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject InviteEnabled;

	[Token(Token = "0x40187D0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject InviteDisabled;

	[Token(Token = "0x60171CA")]
	[Address(RVA = "0x1C20C9C", Offset = "0x1C20C9C", VA = "0x1C20C9C")]
	public UITrainingCampRecommendItemView()
	{
	}

	[Token(Token = "0x60171CB")]
	[Address(RVA = "0x1C20CA4", Offset = "0x1C20CA4", VA = "0x1C20CA4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171CC")]
	[Address(RVA = "0x1C20F48", Offset = "0x1C20F48", VA = "0x1C20F48")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
