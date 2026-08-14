using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036AE")]
public class UIHudMatchResultBaseRewardView : UIBaseView
{
	[Token(Token = "0x4016067")]
	[FieldOffset(Offset = "0x14")]
	public UITable ItemTable;

	[Token(Token = "0x4016068")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GoldIcon;

	[Token(Token = "0x4016069")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel GoldCount;

	[Token(Token = "0x401606A")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ExpIcon;

	[Token(Token = "0x401606B")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ExpCount;

	[Token(Token = "0x401606C")]
	[FieldOffset(Offset = "0x28")]
	public UISprite PetExpIcon;

	[Token(Token = "0x401606D")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel PetExpCount;

	[Token(Token = "0x401606E")]
	[FieldOffset(Offset = "0x30")]
	public UIButton DetailBtn;

	[Token(Token = "0x401606F")]
	[FieldOffset(Offset = "0x34")]
	public UIButton DetailMaskBtn;

	[Token(Token = "0x4016070")]
	[FieldOffset(Offset = "0x38")]
	public UIMatchResultDetailView MatchResultDetailWindow;

	[Token(Token = "0x60167B7")]
	[Address(RVA = "0x19AEBBC", Offset = "0x19AEBBC", VA = "0x19AEBBC")]
	public UIHudMatchResultBaseRewardView()
	{
	}

	[Token(Token = "0x60167B8")]
	[Address(RVA = "0x19AEBC4", Offset = "0x19AEBC4", VA = "0x19AEBC4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167B9")]
	[Address(RVA = "0x19AF0C0", Offset = "0x19AF0C0", VA = "0x19AF0C0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
