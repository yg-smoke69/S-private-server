using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200380F")]
public class UILadderMatchResetMatchRewardWndView : UIBaseView
{
	[Token(Token = "0x4016C9F")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ResetMatchTipsLabel;

	[Token(Token = "0x4016CA0")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4016CA1")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList EasyList;

	[Token(Token = "0x6016BD8")]
	[Address(RVA = "0x22BF320", Offset = "0x22BF320", VA = "0x22BF320")]
	public UILadderMatchResetMatchRewardWndView()
	{
	}

	[Token(Token = "0x6016BD9")]
	[Address(RVA = "0x22BF328", Offset = "0x22BF328", VA = "0x22BF328", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BDA")]
	[Address(RVA = "0x22BF590", Offset = "0x22BF590", VA = "0x22BF590")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
