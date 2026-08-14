using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002553")]
public class UIClanSearchPopController : UIPopupWindowController
{
	[Token(Token = "0x2002554")]
	private sealed class _003CGenerateAreaMenuData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E73B")]
		[FieldOffset(Offset = "0x8")]
		internal ClanAreaData area;

		[Token(Token = "0x600D9A6")]
		[Address(RVA = "0x2B48754", Offset = "0x2B48754", VA = "0x2B48754")]
		public _003CGenerateAreaMenuData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D9A7")]
		[Address(RVA = "0x2B49108", Offset = "0x2B49108", VA = "0x2B49108")]
		internal bool _003C_003Em__0(string temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002555")]
	private sealed class _003CGenerateAreaMenuData_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E73C")]
		[FieldOffset(Offset = "0x8")]
		internal ClanAreaData area;

		[Token(Token = "0x600D9A8")]
		[Address(RVA = "0x2B4875C", Offset = "0x2B4875C", VA = "0x2B4875C")]
		public _003CGenerateAreaMenuData_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600D9A9")]
		[Address(RVA = "0x2B491AC", Offset = "0x2B491AC", VA = "0x2B491AC")]
		internal bool _003C_003Em__0(PopMenuData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E731")]
	private const string m_DefaultText = "TXT_SETTING_AIDER_ALLON";

	[Token(Token = "0x400E732")]
	[FieldOffset(Offset = "0x48")]
	protected UIClanSearchPopView m_View;

	[Token(Token = "0x400E733")]
	[FieldOffset(Offset = "0x4C")]
	protected List<PopMenuData> m_DataList;

	[Token(Token = "0x400E734")]
	[FieldOffset(Offset = "0x50")]
	protected uint m_AreaId;

	[Token(Token = "0x400E735")]
	[FieldOffset(Offset = "0x54")]
	protected uint m_PlayStyleId;

	[Token(Token = "0x400E736")]
	[FieldOffset(Offset = "0x58")]
	protected UIPopMenuSmallControler m_SelectRegionPopMenuSmallCtrl;

	[Token(Token = "0x400E737")]
	[FieldOffset(Offset = "0x5C")]
	protected UIPopMenuSmallControler m_SelectStyleModePopMenuSmallCtrl;

	[Token(Token = "0x400E738")]
	[FieldOffset(Offset = "0x60")]
	private PopMenuData m_DefaultMenuData;

	[Token(Token = "0x400E739")]
	[FieldOffset(Offset = "0x64")]
	private string m_InRegionText;

	[Token(Token = "0x400E73A")]
	[FieldOffset(Offset = "0x68")]
	private string m_InStyleText;

	[Token(Token = "0x600D996")]
	[Address(RVA = "0x2B47380", Offset = "0x2B47380", VA = "0x2B47380")]
	public UIClanSearchPopController()
	{
	}

	[Token(Token = "0x600D997")]
	[Address(RVA = "0x2B4740C", Offset = "0x2B4740C", VA = "0x2B4740C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D998")]
	[Address(RVA = "0x2B45184", Offset = "0x2B45184", VA = "0x2B45184")]
	public void SetData(UIWidget widget, uint areaId, uint playStyle)
	{
	}

	[Token(Token = "0x600D999")]
	[Address(RVA = "0x2B4777C", Offset = "0x2B4777C", VA = "0x2B4777C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D99A")]
	[Address(RVA = "0x2B474B0", Offset = "0x2B474B0", VA = "0x2B474B0")]
	private void InitPopMenus()
	{
	}

	[Token(Token = "0x600D99B")]
	[Address(RVA = "0x2B47B94", Offset = "0x2B47B94", VA = "0x2B47B94", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D99C")]
	[Address(RVA = "0x2B47C04", Offset = "0x2B47C04", VA = "0x2B47C04")]
	protected void GenerateAreaMenuData()
	{
	}

	[Token(Token = "0x600D99D")]
	[Address(RVA = "0x2B48764", Offset = "0x2B48764", VA = "0x2B48764")]
	private void OnRegionSelected(object obj)
	{
	}

	[Token(Token = "0x600D99E")]
	[Address(RVA = "0x2B48A44", Offset = "0x2B48A44", VA = "0x2B48A44")]
	protected void GeneratePlayStyleMenuData()
	{
	}

	[Token(Token = "0x600D99F")]
	[Address(RVA = "0x2B48F70", Offset = "0x2B48F70", VA = "0x2B48F70")]
	private void OnPlayStyleSelected(object obj)
	{
	}

	[Token(Token = "0x600D9A0")]
	[Address(RVA = "0x2B48828", Offset = "0x2B48828", VA = "0x2B48828")]
	private void OnSearchClick()
	{
	}

	[Token(Token = "0x600D9A1")]
	[Address(RVA = "0x2B49034", Offset = "0x2B49034", VA = "0x2B49034")]
	private void OnPopWindowClose()
	{
	}

	[Token(Token = "0x600D9A2")]
	[Address(RVA = "0x2B49098", Offset = "0x2B49098", VA = "0x2B49098", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600D9A3")]
	[Address(RVA = "0x2B490F0", Offset = "0x2B490F0", VA = "0x2B490F0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D9A4")]
	[Address(RVA = "0x2B490F8", Offset = "0x2B490F8", VA = "0x2B490F8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600D9A5")]
	[Address(RVA = "0x2B49100", Offset = "0x2B49100", VA = "0x2B49100")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}
}
