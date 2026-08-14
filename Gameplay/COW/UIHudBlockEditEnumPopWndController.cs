using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000BEB")]
public class UIHudBlockEditEnumPopWndController : UIPopupWindowController
{
	[Token(Token = "0x2000BEC")]
	private sealed class _003CSetView_003Ec__AnonStorey0
	{
		[Token(Token = "0x4006312")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudBlockEditEnumPopItemController ctrl;

		[Token(Token = "0x4006313")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudBlockEditEnumPopWndController _0024this;

		[Token(Token = "0x6005A30")]
		[Address(RVA = "0x1E04F60", Offset = "0x1E04F60", VA = "0x1E04F60")]
		public _003CSetView_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6005A31")]
		[Address(RVA = "0x1E0582C", Offset = "0x1E0582C", VA = "0x1E0582C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400630B")]
	[FieldOffset(Offset = "0x48")]
	private UIHudBlockEditEnumPopWndView m_View;

	[Token(Token = "0x400630C")]
	[FieldOffset(Offset = "0x4C")]
	private UIHudBlockEditEnumPopItemController m_CurrentItem;

	[Token(Token = "0x400630D")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<string, List<UIHudBlockEditEnumPopItemController>> m_CatagoryDic;

	[Token(Token = "0x400630E")]
	[FieldOffset(Offset = "0x54")]
	private UIPopMenuSmallControler m_PopCtrl;

	[Token(Token = "0x400630F")]
	[FieldOffset(Offset = "0x58")]
	private List<PopMenuData> m_PopDatas;

	[Token(Token = "0x4006310")]
	[FieldOffset(Offset = "0x5C")]
	private string m_CurrentGroup;

	[Token(Token = "0x4006311")]
	[FieldOffset(Offset = "0x60")]
	private UIGrid m_Grid;

	[Token(Token = "0x6005A27")]
	[Address(RVA = "0x1E03EC8", Offset = "0x1E03EC8", VA = "0x1E03EC8")]
	public UIHudBlockEditEnumPopWndController()
	{
	}

	[Token(Token = "0x6005A28")]
	[Address(RVA = "0x1E03F54", Offset = "0x1E03F54", VA = "0x1E03F54")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6005A29")]
	[Address(RVA = "0x1E03FF8", Offset = "0x1E03FF8", VA = "0x1E03FF8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6005A2A")]
	[Address(RVA = "0x1E04364", Offset = "0x1E04364", VA = "0x1E04364")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x6005A2B")]
	[Address(RVA = "0x1E043C8", Offset = "0x1E043C8", VA = "0x1E043C8")]
	private void OnItemSelect(UIHudBlockEditEnumPopItemController select)
	{
	}

	[Token(Token = "0x6005A2C")]
	[Address(RVA = "0x1E0455C", Offset = "0x1E0455C", VA = "0x1E0455C")]
	public void SetView(EBEPopWndType type, List<BEPopWndItemData> datas, BEPopWndItemData current)
	{
	}

	[Token(Token = "0x6005A2D")]
	[Address(RVA = "0x1E05448", Offset = "0x1E05448", VA = "0x1E05448")]
	private void OnPopEnumClick()
	{
	}

	[Token(Token = "0x6005A2E")]
	[Address(RVA = "0x1E04F68", Offset = "0x1E04F68", VA = "0x1E04F68")]
	private void OnCatagorySelect(object obj)
	{
	}

	[Token(Token = "0x6005A2F")]
	[Address(RVA = "0x1E05824", Offset = "0x1E05824", VA = "0x1E05824")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
