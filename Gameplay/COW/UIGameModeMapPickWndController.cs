using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026AC")]
public class UIGameModeMapPickWndController : UIPopupWindowController
{
	[Token(Token = "0x400EEAC")]
	[FieldOffset(Offset = "0x48")]
	private UIGameModeMapPickWndView m_View;

	[Token(Token = "0x400EEAD")]
	[FieldOffset(Offset = "0x4C")]
	private List<MapModeData> m_Selected;

	[Token(Token = "0x400EEAE")]
	[FieldOffset(Offset = "0x50")]
	private uint m_GameMode;

	[Token(Token = "0x400EEAF")]
	[FieldOffset(Offset = "0x54")]
	private uint m_MatchMode;

	[Token(Token = "0x400EEB0")]
	[FieldOffset(Offset = "0x58")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x400EEB1")]
	[FieldOffset(Offset = "0x5C")]
	private List<UIGameModeMapPickItemController> m_PickItemCtrls;

	[Token(Token = "0x400EEB2")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<MapModeData, uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600E8FF")]
	[Address(RVA = "0x2189C00", Offset = "0x2189C00", VA = "0x2189C00")]
	public UIGameModeMapPickWndController()
	{
	}

	[Token(Token = "0x600E900")]
	[Address(RVA = "0x2189C08", Offset = "0x2189C08", VA = "0x2189C08")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E901")]
	[Address(RVA = "0x2189CB0", Offset = "0x2189CB0", VA = "0x2189CB0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E902")]
	[Address(RVA = "0x2189FA4", Offset = "0x2189FA4", VA = "0x2189FA4")]
	public void SetData(List<MapModeData> data)
	{
	}

	[Token(Token = "0x600E903")]
	[Address(RVA = "0x21891A4", Offset = "0x21891A4", VA = "0x21891A4")]
	public bool CanCancel()
	{
		return default(bool);
	}

	[Token(Token = "0x600E904")]
	[Address(RVA = "0x218A6B0", Offset = "0x218A6B0", VA = "0x218A6B0")]
	private void OnClickConfirm()
	{
	}

	[Token(Token = "0x600E905")]
	[Address(RVA = "0x218ABA8", Offset = "0x218ABA8", VA = "0x218ABA8")]
	private void OnClickSelectAll()
	{
	}

	[Token(Token = "0x600E906")]
	[Address(RVA = "0x218AFBC", Offset = "0x218AFBC", VA = "0x218AFBC")]
	private void OnItemSelect(object[] data)
	{
	}

	[Token(Token = "0x600E907")]
	[Address(RVA = "0x218A59C", Offset = "0x218A59C", VA = "0x218A59C")]
	private void RefreshAllPickTick()
	{
	}

	[Token(Token = "0x600E908")]
	[Address(RVA = "0x218AD7C", Offset = "0x218AD7C", VA = "0x218AD7C")]
	private bool IsPickAll()
	{
		return default(bool);
	}

	[Token(Token = "0x600E909")]
	[Address(RVA = "0x218B330", Offset = "0x218B330", VA = "0x218B330")]
	private static uint _003COnClickConfirm_003Em__0(MapModeData x)
	{
		return default(uint);
	}

	[Token(Token = "0x600E90A")]
	[Address(RVA = "0x218B354", Offset = "0x218B354", VA = "0x218B354")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
