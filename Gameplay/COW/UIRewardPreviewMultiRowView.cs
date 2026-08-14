using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200395B")]
public class UIRewardPreviewMultiRowView : UIBaseView
{
	[Token(Token = "0x4018029")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid RowGrid;

	[Token(Token = "0x401802A")]
	[FieldOffset(Offset = "0x18")]
	public UIButton OKBtn;

	[Token(Token = "0x401802B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel BtnLabel;

	[Token(Token = "0x6016FB8")]
	[Address(RVA = "0x1E594DC", Offset = "0x1E594DC", VA = "0x1E594DC")]
	public UIRewardPreviewMultiRowView()
	{
	}

	[Token(Token = "0x6016FB9")]
	[Address(RVA = "0x1E594E4", Offset = "0x1E594E4", VA = "0x1E594E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FBA")]
	[Address(RVA = "0x1E5974C", Offset = "0x1E5974C", VA = "0x1E5974C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
