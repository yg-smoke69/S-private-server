using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200351F")]
public class UIEPDebrisRewardView : UIBaseView
{
	[Token(Token = "0x4014F79")]
	[FieldOffset(Offset = "0x14")]
	public UISprite EPBadgeSpr;

	[Token(Token = "0x4014F7A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel BadgeCnt;

	[Token(Token = "0x4014F7B")]
	[FieldOffset(Offset = "0x1C")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x4014F7C")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ProcessCnt;

	[Token(Token = "0x4014F7D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ConstDebrisRate;

	[Token(Token = "0x4014F7E")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TipLabel;

	[Token(Token = "0x4014F7F")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton SkipBtn;

	[Token(Token = "0x601630D")]
	[Address(RVA = "0x2BACE44", Offset = "0x2BACE44", VA = "0x2BACE44")]
	public UIEPDebrisRewardView()
	{
	}

	[Token(Token = "0x601630E")]
	[Address(RVA = "0x2BACE4C", Offset = "0x2BACE4C", VA = "0x2BACE4C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601630F")]
	[Address(RVA = "0x2BAD234", Offset = "0x2BAD234", VA = "0x2BAD234")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
