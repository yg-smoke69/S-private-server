using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003871")]
public class UIMallGiftSendSuccessView : UIBaseView
{
	[Token(Token = "0x4017366")]
	[FieldOffset(Offset = "0x14")]
	public Transform UIMallGiftSendSuccess;

	[Token(Token = "0x4017367")]
	[FieldOffset(Offset = "0x18")]
	public TweenColor tweenColor;

	[Token(Token = "0x4017368")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CloseBtn;

	[Token(Token = "0x6016CFE")]
	[Address(RVA = "0x225DDD8", Offset = "0x225DDD8", VA = "0x225DDD8")]
	public UIMallGiftSendSuccessView()
	{
	}

	[Token(Token = "0x6016CFF")]
	[Address(RVA = "0x225DDE0", Offset = "0x225DDE0", VA = "0x225DDE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D00")]
	[Address(RVA = "0x225E020", Offset = "0x225E020", VA = "0x225E020")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
