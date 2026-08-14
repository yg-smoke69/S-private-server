using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003959")]
public class UIRewardPreviewItemRowView : UIBaseView
{
	[Token(Token = "0x4018020")]
	[FieldOffset(Offset = "0x14")]
	public UILabel DescLabel;

	[Token(Token = "0x4018021")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid PreviewGrid;

	[Token(Token = "0x6016FB2")]
	[Address(RVA = "0x1E58910", Offset = "0x1E58910", VA = "0x1E58910")]
	public UIRewardPreviewItemRowView()
	{
	}

	[Token(Token = "0x6016FB3")]
	[Address(RVA = "0x1E58918", Offset = "0x1E58918", VA = "0x1E58918", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FB4")]
	[Address(RVA = "0x1E58B20", Offset = "0x1E58B20", VA = "0x1E58B20")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
