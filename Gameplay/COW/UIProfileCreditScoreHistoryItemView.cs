using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200391F")]
public class UIProfileCreditScoreHistoryItemView : UIBaseView
{
	[Token(Token = "0x4017C69")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelScore;

	[Token(Token = "0x4017C6A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelReason;

	[Token(Token = "0x4017C6B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelScoreChanges;

	[Token(Token = "0x4017C6C")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelTime;

	[Token(Token = "0x6016F04")]
	[Address(RVA = "0x16D31B8", Offset = "0x16D31B8", VA = "0x16D31B8")]
	public UIProfileCreditScoreHistoryItemView()
	{
	}

	[Token(Token = "0x6016F05")]
	[Address(RVA = "0x16D31C0", Offset = "0x16D31C0", VA = "0x16D31C0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F06")]
	[Address(RVA = "0x16D3488", Offset = "0x16D3488", VA = "0x16D3488")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
