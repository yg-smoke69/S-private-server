using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200259E")]
internal class UICommonSettingItemController : UICommonSettingItemBaseController
{
	[Token(Token = "0x200259F")]
	private sealed class _003CSetViewData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E8C1")]
		[FieldOffset(Offset = "0x8")]
		internal CommonSettingItemDataToggleBtns data;

		[Token(Token = "0x400E8C2")]
		[FieldOffset(Offset = "0xC")]
		internal UICommonSettingItemController _0024this;

		[Token(Token = "0x600DC33")]
		[Address(RVA = "0x1EB6830", Offset = "0x1EB6830", VA = "0x1EB6830")]
		public _003CSetViewData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600DC34")]
		[Address(RVA = "0x1EB74D4", Offset = "0x1EB74D4", VA = "0x1EB74D4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20025A0")]
	private sealed class _003CSetViewData_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E8C3")]
		[FieldOffset(Offset = "0x8")]
		internal Action click;

		[Token(Token = "0x600DC35")]
		[Address(RVA = "0x1EB6838", Offset = "0x1EB6838", VA = "0x1EB6838")]
		public _003CSetViewData_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600DC36")]
		[Address(RVA = "0x1EB7538", Offset = "0x1EB7538", VA = "0x1EB7538")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20025A1")]
	private sealed class _003CSetViewData_003Ec__AnonStorey2
	{
		[Token(Token = "0x400E8C4")]
		[FieldOffset(Offset = "0x8")]
		internal int val;

		[Token(Token = "0x400E8C5")]
		[FieldOffset(Offset = "0xC")]
		internal _003CSetViewData_003Ec__AnonStorey0 _003C_003Ef__ref_00240;

		[Token(Token = "0x600DC37")]
		[Address(RVA = "0x1EB6840", Offset = "0x1EB6840", VA = "0x1EB6840")]
		public _003CSetViewData_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600DC38")]
		[Address(RVA = "0x1EB754C", Offset = "0x1EB754C", VA = "0x1EB754C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400E8BE")]
	[FieldOffset(Offset = "0x2C")]
	protected CommonSettingItemDataToggleBtns m_Data;

	[Token(Token = "0x400E8BF")]
	[FieldOffset(Offset = "0x30")]
	private UICommonSettingItemView m_View;

	[Token(Token = "0x400E8C0")]
	[FieldOffset(Offset = "0x34")]
	private List<CommonSettingToggleItem> m_Toggles;

	[Token(Token = "0x600DC26")]
	[Address(RVA = "0x1EB5180", Offset = "0x1EB5180", VA = "0x1EB5180")]
	public UICommonSettingItemController()
	{
	}

	[Token(Token = "0x600DC27")]
	[Address(RVA = "0x1EB5208", Offset = "0x1EB5208", VA = "0x1EB5208")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DC28")]
	[Address(RVA = "0x1EB52B0", Offset = "0x1EB52B0", VA = "0x1EB52B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DC29")]
	[Address(RVA = "0x1EB5360", Offset = "0x1EB5360", VA = "0x1EB5360", Slot = "31")]
	public override void SetViewData(CommonSettingItemDataBase baseData, int type)
	{
	}

	[Token(Token = "0x600DC2A")]
	[Address(RVA = "0x1EB6848", Offset = "0x1EB6848", VA = "0x1EB6848")]
	public void UpdateToggles()
	{
	}

	[Token(Token = "0x600DC2B")]
	[Address(RVA = "0x1EB6DB0", Offset = "0x1EB6DB0", VA = "0x1EB6DB0")]
	public int GetSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600DC2C")]
	[Address(RVA = "0x1EB6F0C", Offset = "0x1EB6F0C", VA = "0x1EB6F0C", Slot = "32")]
	public override void RefreshContent()
	{
	}

	[Token(Token = "0x600DC2D")]
	[Address(RVA = "0x1EB7240", Offset = "0x1EB7240", VA = "0x1EB7240", Slot = "33")]
	public override void RefreshTips()
	{
	}

	[Token(Token = "0x600DC2E")]
	[Address(RVA = "0x1EB7450", Offset = "0x1EB7450", VA = "0x1EB7450")]
	public UIWidget GetWidget()
	{
		return null;
	}

	[Token(Token = "0x600DC2F")]
	[Address(RVA = "0x1EB74C0", Offset = "0x1EB74C0", VA = "0x1EB74C0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DC30")]
	[Address(RVA = "0x1EB74C8", Offset = "0x1EB74C8", VA = "0x1EB74C8")]
	public void _003C_003EiFixBaseProxy_SetViewData(CommonSettingItemDataBase P0, int P1)
	{
	}

	[Token(Token = "0x600DC31")]
	[Address(RVA = "0x1EB74CC", Offset = "0x1EB74CC", VA = "0x1EB74CC")]
	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}

	[Token(Token = "0x600DC32")]
	[Address(RVA = "0x1EB74D0", Offset = "0x1EB74D0", VA = "0x1EB74D0")]
	public void _003C_003EiFixBaseProxy_RefreshTips()
	{
	}
}
