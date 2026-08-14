using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025A2")]
internal class UICommonSettingSliderItemController : UICommonSettingItemBaseController
{
	[Token(Token = "0x20025A3")]
	private sealed class _003CSetViewData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E8C8")]
		[FieldOffset(Offset = "0x8")]
		internal CommonSettingItemDataSlider data;

		[Token(Token = "0x600DC42")]
		[Address(RVA = "0x1EB88FC", Offset = "0x1EB88FC", VA = "0x1EB88FC")]
		public _003CSetViewData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600DC43")]
		[Address(RVA = "0x1EB8C8C", Offset = "0x1EB8C8C", VA = "0x1EB8C8C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400E8C6")]
	[FieldOffset(Offset = "0x2C")]
	protected CommonSettingItemDataSlider m_Data;

	[Token(Token = "0x400E8C7")]
	[FieldOffset(Offset = "0x30")]
	private UICommonSettingSliderItemView m_View;

	[Token(Token = "0x600DC39")]
	[Address(RVA = "0x1EB82A4", Offset = "0x1EB82A4", VA = "0x1EB82A4")]
	public UICommonSettingSliderItemController()
	{
	}

	[Token(Token = "0x600DC3A")]
	[Address(RVA = "0x1EB82A8", Offset = "0x1EB82A8", VA = "0x1EB82A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DC3B")]
	[Address(RVA = "0x1EB8350", Offset = "0x1EB8350", VA = "0x1EB8350", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DC3C")]
	[Address(RVA = "0x1EB8400", Offset = "0x1EB8400", VA = "0x1EB8400", Slot = "31")]
	public override void SetViewData(CommonSettingItemDataBase baseData, int type)
	{
	}

	[Token(Token = "0x600DC3D")]
	[Address(RVA = "0x1EB8904", Offset = "0x1EB8904", VA = "0x1EB8904")]
	private void OnSliderChange()
	{
	}

	[Token(Token = "0x600DC3E")]
	[Address(RVA = "0x1EB8B28", Offset = "0x1EB8B28", VA = "0x1EB8B28", Slot = "32")]
	public override void RefreshContent()
	{
	}

	[Token(Token = "0x600DC3F")]
	[Address(RVA = "0x1EB8C7C", Offset = "0x1EB8C7C", VA = "0x1EB8C7C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DC40")]
	[Address(RVA = "0x1EB8C84", Offset = "0x1EB8C84", VA = "0x1EB8C84")]
	public void _003C_003EiFixBaseProxy_SetViewData(CommonSettingItemDataBase P0, int P1)
	{
	}

	[Token(Token = "0x600DC41")]
	[Address(RVA = "0x1EB8C88", Offset = "0x1EB8C88", VA = "0x1EB8C88")]
	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}
