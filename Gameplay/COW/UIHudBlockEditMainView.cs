using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035EE")]
public class UIHudBlockEditMainView : UIBaseView
{
	[Token(Token = "0x401596B")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid GridBlockType;

	[Token(Token = "0x401596C")]
	[FieldOffset(Offset = "0x18")]
	public UITable TBBlockPreset;

	[Token(Token = "0x401596D")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject TrashSurface;

	[Token(Token = "0x401596E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BlockPresetContainer;

	[Token(Token = "0x401596F")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnClose;

	[Token(Token = "0x4015970")]
	[FieldOffset(Offset = "0x28")]
	public UIHudBlockTypeBtnItemController BtnItem;

	[Token(Token = "0x4015971")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel BlockName;

	[Token(Token = "0x4015972")]
	[FieldOffset(Offset = "0x30")]
	public UIScrollView SVBlockItems;

	[Token(Token = "0x4015973")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnHelp;

	[Token(Token = "0x4015974")]
	[FieldOffset(Offset = "0x38")]
	public UILabel TitleLabel;

	[Token(Token = "0x4015975")]
	[FieldOffset(Offset = "0x3C")]
	public UIPanel MainPanel;

	[Token(Token = "0x4015976")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnCreateDynamicBlock;

	[Token(Token = "0x4015977")]
	[FieldOffset(Offset = "0x44")]
	public UIHudBlockTypeBtnItemController BtnLocalGraphContent;

	[Token(Token = "0x4015978")]
	[FieldOffset(Offset = "0x48")]
	public UIHudBlockTypeBtnItemController BtnGlobalGraphContent;

	[Token(Token = "0x4015979")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel LabelCreateDynamicBlock;

	[Token(Token = "0x6016578")]
	[Address(RVA = "0x1E05F9C", Offset = "0x1E05F9C", VA = "0x1E05F9C")]
	public UIHudBlockEditMainView()
	{
	}

	[Token(Token = "0x6016579")]
	[Address(RVA = "0x1E05FA4", Offset = "0x1E05FA4", VA = "0x1E05FA4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601657A")]
	[Address(RVA = "0x1E06674", Offset = "0x1E06674", VA = "0x1E06674")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
