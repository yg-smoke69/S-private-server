using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002417")]
public class UIUGCHudWidgetAttributeSpriteController : UIUGCHudWidgetAttributeController<string>, _Attribute
{
	[Token(Token = "0x2002418")]
	private sealed class _003CInitAttribute_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E0CC")]
		[FieldOffset(Offset = "0x8")]
		internal string data;

		[Token(Token = "0x600CC05")]
		[Address(RVA = "0x2FF7D30", Offset = "0x2FF7D30", VA = "0x2FF7D30")]
		public _003CInitAttribute_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600CC06")]
		[Address(RVA = "0x2FF885C", Offset = "0x2FF885C", VA = "0x2FF885C")]
		internal bool _003C_003Em__0(string x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002419")]
	private sealed class _003COnBtnClick_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E0CD")]
		[FieldOffset(Offset = "0x8")]
		internal string strValue;

		[Token(Token = "0x600CC07")]
		[Address(RVA = "0x2FF884C", Offset = "0x2FF884C", VA = "0x2FF884C")]
		public _003COnBtnClick_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600CC08")]
		[Address(RVA = "0x2FF88EC", Offset = "0x2FF88EC", VA = "0x2FF88EC")]
		internal bool _003C_003Em__0(string x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E0C9")]
	[FieldOffset(Offset = "0x34")]
	private UIUGCHudWidgetAttributeSpriteView m_View;

	[Token(Token = "0x400E0CA")]
	[FieldOffset(Offset = "0x38")]
	private List<string> m_SpriteNames;

	[Token(Token = "0x400E0CB")]
	[FieldOffset(Offset = "0x3C")]
	private int m_SelectIndex;

	[Token(Token = "0x170010FF")]
	public override string AttributeData
	{
		[Token(Token = "0x600CBFB")]
		[Address(RVA = "0x2FF7D38", Offset = "0x2FF7D38", VA = "0x2FF7D38", Slot = "36")]
		get
		{
			return null;
		}
		[Token(Token = "0x600CBFC")]
		[Address(RVA = "0x2FF7D90", Offset = "0x2FF7D90", VA = "0x2FF7D90", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x600CBF7")]
	[Address(RVA = "0x2FF79D8", Offset = "0x2FF79D8", VA = "0x2FF79D8")]
	public UIUGCHudWidgetAttributeSpriteController()
	{
	}

	[Token(Token = "0x600CBF8")]
	[Address(RVA = "0x2FF7A70", Offset = "0x2FF7A70", VA = "0x2FF7A70")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CBF9")]
	[Address(RVA = "0x2FF7B14", Offset = "0x2FF7B14", VA = "0x2FF7B14", Slot = "31")]
	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return default(UIUGCHudWidgetAttributeEnum);
	}

	[Token(Token = "0x600CBFA")]
	[Address(RVA = "0x2FF7B6C", Offset = "0x2FF7B6C", VA = "0x2FF7B6C", Slot = "38")]
	public override void InitAttribute(string data)
	{
	}

	[Token(Token = "0x600CBFD")]
	[Address(RVA = "0x2FF7E9C", Offset = "0x2FF7E9C", VA = "0x2FF7E9C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CBFE")]
	[Address(RVA = "0x2FF825C", Offset = "0x2FF825C", VA = "0x2FF825C")]
	public void SetViewData(string title)
	{
	}

	[Token(Token = "0x600CBFF")]
	[Address(RVA = "0x2FF82F4", Offset = "0x2FF82F4", VA = "0x2FF82F4")]
	private void SelectItem(int index)
	{
	}

	[Token(Token = "0x600CC00")]
	[Address(RVA = "0x2FF842C", Offset = "0x2FF842C", VA = "0x2FF842C", Slot = "39")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600CC01")]
	[Address(RVA = "0x2FF8584", Offset = "0x2FF8584", VA = "0x2FF8584", Slot = "40")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600CC02")]
	[Address(RVA = "0x2FF8600", Offset = "0x2FF8600", VA = "0x2FF8600")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600CC03")]
	[Address(RVA = "0x2FF8714", Offset = "0x2FF8714", VA = "0x2FF8714")]
	private void _003COnBtnClick_003Em__0(string strValue, int intValue)
	{
	}

	[Token(Token = "0x600CC04")]
	[Address(RVA = "0x2FF8854", Offset = "0x2FF8854", VA = "0x2FF8854")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
