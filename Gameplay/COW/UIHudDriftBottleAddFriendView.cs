using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200363A")]
public class UIHudDriftBottleAddFriendView : UIBaseView
{
	[Token(Token = "0x4015C0D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Message;

	[Token(Token = "0x4015C0E")]
	[FieldOffset(Offset = "0x18")]
	public UIButton OKBtn;

	[Token(Token = "0x4015C0F")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CloseBtn;

	[Token(Token = "0x4015C10")]
	[FieldOffset(Offset = "0x20")]
	public UILabel CloseTime;

	[Token(Token = "0x601665B")]
	[Address(RVA = "0x1CD8630", Offset = "0x1CD8630", VA = "0x1CD8630")]
	public UIHudDriftBottleAddFriendView()
	{
	}

	[Token(Token = "0x601665C")]
	[Address(RVA = "0x1CD8638", Offset = "0x1CD8638", VA = "0x1CD8638", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601665D")]
	[Address(RVA = "0x1CD8900", Offset = "0x1CD8900", VA = "0x1CD8900")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
