using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200351E")]
public class UIEPDebrisProcessView : UIBaseView
{
	[Token(Token = "0x4014F75")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BadgeIcon;

	[Token(Token = "0x4014F76")]
	[FieldOffset(Offset = "0x18")]
	public UILabel BadgeCnt;

	[Token(Token = "0x4014F77")]
	[FieldOffset(Offset = "0x1C")]
	public UIProgressBar EpProgressBar;

	[Token(Token = "0x4014F78")]
	[FieldOffset(Offset = "0x20")]
	public UILabel EpProcessCnt;

	[Token(Token = "0x601630A")]
	[Address(RVA = "0x2BAB6DC", Offset = "0x2BAB6DC", VA = "0x2BAB6DC")]
	public UIEPDebrisProcessView()
	{
	}

	[Token(Token = "0x601630B")]
	[Address(RVA = "0x2BAB6E4", Offset = "0x2BAB6E4", VA = "0x2BAB6E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601630C")]
	[Address(RVA = "0x2BAB9AC", Offset = "0x2BAB9AC", VA = "0x2BAB9AC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
