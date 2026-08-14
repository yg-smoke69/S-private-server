using System.Collections.Generic;
using GCommon;
using GCommon.UGCUI;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002433")]
public class UIUGCHudWidgetInspectorController : UIBaseController
{
	[Token(Token = "0x2002434")]
	private sealed class _003CBindAttribute_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E155")]
		[FieldOffset(Offset = "0x8")]
		internal UGCHudWidget widget;

		[Token(Token = "0x400E156")]
		[FieldOffset(Offset = "0xC")]
		internal UIUGCHudWidgetInspectorController _0024this;

		[Token(Token = "0x600CD66")]
		[Address(RVA = "0x2774FE0", Offset = "0x2774FE0", VA = "0x2774FE0")]
		public _003CBindAttribute_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600CD67")]
		[Address(RVA = "0x2774FE8", Offset = "0x2774FE8", VA = "0x2774FE8")]
		internal void _003C_003Em__0(UIUGCHudWidgetAttributeTransformController.TransformData value)
		{
		}

		[Token(Token = "0x600CD68")]
		[Address(RVA = "0x277515C", Offset = "0x277515C", VA = "0x277515C")]
		internal void _003C_003Em__1(bool value)
		{
		}

		[Token(Token = "0x600CD69")]
		[Address(RVA = "0x2775288", Offset = "0x2775288", VA = "0x2775288")]
		internal void _003C_003Em__2(Vector2Int value)
		{
		}

		[Token(Token = "0x600CD6A")]
		[Address(RVA = "0x277530C", Offset = "0x277530C", VA = "0x277530C")]
		internal void _003C_003Em__3(Color color)
		{
		}
	}

	[Token(Token = "0x2002435")]
	private sealed class _003CBindAttribute_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E157")]
		[FieldOffset(Offset = "0x8")]
		internal UGCHudImage image;

		[Token(Token = "0x400E158")]
		[FieldOffset(Offset = "0xC")]
		internal _003CBindAttribute_003Ec__AnonStorey0 _003C_003Ef__ref_00240;

		[Token(Token = "0x600CD6B")]
		[Address(RVA = "0x2775380", Offset = "0x2775380", VA = "0x2775380")]
		public _003CBindAttribute_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600CD6C")]
		[Address(RVA = "0x2775388", Offset = "0x2775388", VA = "0x2775388")]
		internal void _003C_003Em__0(string value)
		{
		}
	}

	[Token(Token = "0x2002436")]
	private sealed class _003CBindAttribute_003Ec__AnonStorey2
	{
		[Token(Token = "0x400E159")]
		[FieldOffset(Offset = "0x8")]
		internal UGCHudImage image;

		[Token(Token = "0x600CD6D")]
		[Address(RVA = "0x2775488", Offset = "0x2775488", VA = "0x2775488")]
		public _003CBindAttribute_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600CD6E")]
		[Address(RVA = "0x2775490", Offset = "0x2775490", VA = "0x2775490")]
		internal void _003C_003Em__0(Flip flip)
		{
		}
	}

	[Token(Token = "0x2002437")]
	private sealed class _003CBindAttribute_003Ec__AnonStorey3
	{
		[Token(Token = "0x400E15A")]
		[FieldOffset(Offset = "0x8")]
		internal UGCHudLabel label;

		[Token(Token = "0x600CD6F")]
		[Address(RVA = "0x27754E4", Offset = "0x27754E4", VA = "0x27754E4")]
		public _003CBindAttribute_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x600CD70")]
		[Address(RVA = "0x27754EC", Offset = "0x27754EC", VA = "0x27754EC")]
		internal void _003C_003Em__0(Alignment value)
		{
		}
	}

	[Token(Token = "0x2002438")]
	private sealed class _003CBindAttribute_003Ec__AnonStorey4
	{
		[Token(Token = "0x400E15B")]
		[FieldOffset(Offset = "0x8")]
		internal UGCHudLabel label;

		[Token(Token = "0x600CD71")]
		[Address(RVA = "0x2775540", Offset = "0x2775540", VA = "0x2775540")]
		public _003CBindAttribute_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x600CD72")]
		[Address(RVA = "0x2775548", Offset = "0x2775548", VA = "0x2775548")]
		internal void _003C_003Em__0(int value)
		{
		}
	}

	[Token(Token = "0x2002439")]
	private sealed class _003CBindAttribute_003Ec__AnonStorey5
	{
		[Token(Token = "0x400E15C")]
		[FieldOffset(Offset = "0x8")]
		internal UGCHudLabel label;

		[Token(Token = "0x600CD73")]
		[Address(RVA = "0x277559C", Offset = "0x277559C", VA = "0x277559C")]
		public _003CBindAttribute_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x600CD74")]
		[Address(RVA = "0x27755A4", Offset = "0x27755A4", VA = "0x27755A4")]
		internal void _003C_003Em__0(Color value)
		{
		}
	}

	[Token(Token = "0x200243A")]
	private sealed class _003CBindAttribute_003Ec__AnonStorey6
	{
		[Token(Token = "0x400E15D")]
		[FieldOffset(Offset = "0x8")]
		internal UGCHudLabel label;

		[Token(Token = "0x600CD75")]
		[Address(RVA = "0x2775618", Offset = "0x2775618", VA = "0x2775618")]
		public _003CBindAttribute_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x600CD76")]
		[Address(RVA = "0x2775620", Offset = "0x2775620", VA = "0x2775620")]
		internal void _003C_003Em__0(string value)
		{
		}
	}

	[Token(Token = "0x200243B")]
	private sealed class _003CBindAttribute_003Ec__AnonStorey7
	{
		[Token(Token = "0x400E15E")]
		[FieldOffset(Offset = "0x8")]
		internal UGCHudButton btn;

		[Token(Token = "0x400E15F")]
		[FieldOffset(Offset = "0xC")]
		internal _003CBindAttribute_003Ec__AnonStorey0 _003C_003Ef__ref_00240;

		[Token(Token = "0x600CD77")]
		[Address(RVA = "0x2775674", Offset = "0x2775674", VA = "0x2775674")]
		public _003CBindAttribute_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x600CD78")]
		[Address(RVA = "0x277567C", Offset = "0x277567C", VA = "0x277567C")]
		internal void _003C_003Em__0(string value)
		{
		}
	}

	[Token(Token = "0x200243C")]
	private sealed class _003CBindAttribute_003Ec__AnonStorey8
	{
		[Token(Token = "0x400E160")]
		[FieldOffset(Offset = "0x8")]
		internal UGCHudButton btn;

		[Token(Token = "0x600CD79")]
		[Address(RVA = "0x277577C", Offset = "0x277577C", VA = "0x277577C")]
		public _003CBindAttribute_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x600CD7A")]
		[Address(RVA = "0x2775784", Offset = "0x2775784", VA = "0x2775784")]
		internal void _003C_003Em__0(Color value)
		{
		}
	}

	[Token(Token = "0x200243D")]
	private sealed class _003CBindAttribute_003Ec__AnonStorey9
	{
		[Token(Token = "0x400E161")]
		[FieldOffset(Offset = "0x8")]
		internal UGCHudButton btn;

		[Token(Token = "0x600CD7B")]
		[Address(RVA = "0x27757F8", Offset = "0x27757F8", VA = "0x27757F8")]
		public _003CBindAttribute_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x600CD7C")]
		[Address(RVA = "0x2775800", Offset = "0x2775800", VA = "0x2775800")]
		internal void _003C_003Em__0(Color value)
		{
		}
	}

	[Token(Token = "0x400E14D")]
	[FieldOffset(Offset = "0x28")]
	private UIUGCHudWidgetInspectorView m_View;

	[Token(Token = "0x400E14E")]
	[FieldOffset(Offset = "0x2C")]
	private UGCHudWidget m_CurrentWidget;

	[Token(Token = "0x400E14F")]
	[FieldOffset(Offset = "0x30")]
	private UIModelUGCHudEdit m_Model;

	[Token(Token = "0x400E150")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsExpand;

	[Token(Token = "0x400E151")]
	[FieldOffset(Offset = "0x38")]
	private UGCHudWidgetType m_LastWidgetType;

	[Token(Token = "0x400E152")]
	[FieldOffset(Offset = "0x3C")]
	private UIUGCHudWidgetAttributeTransformController m_TransformAttributeItem;

	[Token(Token = "0x400E153")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<int, List<UIUGCHudWidgetAttributeBaseController>> m_AttributeItemsByType;

	[Token(Token = "0x400E154")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<int, UIUGCHudWidgetAttributeBaseController> m_AttributeItems;

	[Token(Token = "0x600CD50")]
	[Address(RVA = "0x3005458", Offset = "0x3005458", VA = "0x3005458")]
	public UIUGCHudWidgetInspectorController()
	{
	}

	[Token(Token = "0x600CD51")]
	[Address(RVA = "0x300554C", Offset = "0x300554C", VA = "0x300554C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CD52")]
	[Address(RVA = "0x30055F0", Offset = "0x30055F0", VA = "0x30055F0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CD53")]
	[Address(RVA = "0x2FF121C", Offset = "0x2FF121C", VA = "0x2FF121C")]
	public void BindWidget(UGCHudWidget widget)
	{
	}

	[Token(Token = "0x600CD54")]
	[Address(RVA = "0x3006298", Offset = "0x3006298", VA = "0x3006298")]
	public void SetExpand(bool expand)
	{
	}

	[Token(Token = "0x600CD55")]
	[Address(RVA = "0x3005FE4", Offset = "0x3005FE4", VA = "0x3005FE4")]
	private void RepositionTable()
	{
	}

	[Token(Token = "0x600CD56")]
	[Address(RVA = "0x3005AF0", Offset = "0x3005AF0", VA = "0x3005AF0")]
	private void HideAllAttributeItems()
	{
	}

	[Token(Token = "0x600CD57")]
	[Address(RVA = "0x3006AD4", Offset = "0x3006AD4", VA = "0x3006AD4")]
	private void SetAttributeType(UGCHudWidgetAttributeType attributeType)
	{
	}

	[Token(Token = "0x600CD58")]
	[Address(RVA = "0x300644C", Offset = "0x300644C", VA = "0x300644C")]
	private void InitAttributes(UGCHudWidget widget)
	{
	}

	[Token(Token = "0x600CD59")]
	[Address(RVA = "0x3009528", Offset = "0x3009528", VA = "0x3009528")]
	private void OnSwitchBtnClick()
	{
	}

	[Token(Token = "0x600CD5A")]
	[Address(RVA = "0x300959C", Offset = "0x300959C", VA = "0x300959C")]
	private void OnEditBtnClick()
	{
	}

	[Token(Token = "0x600CD5B")]
	[Address(RVA = "0x3009798", Offset = "0x3009798", VA = "0x3009798")]
	private void OnWidgetSizeChanged()
	{
	}

	[Token(Token = "0x600CD5C")]
	[Address(RVA = "0x300992C", Offset = "0x300992C", VA = "0x300992C")]
	private void OnWidgetPositionChanged()
	{
	}

	[Token(Token = "0x600CD5D")]
	[Address(RVA = "0x3009B64", Offset = "0x3009B64", VA = "0x3009B64")]
	private void OnWidgetRotationChanged()
	{
	}

	[Token(Token = "0x600CD5E")]
	[Address(RVA = "0x30069A0", Offset = "0x30069A0", VA = "0x30069A0")]
	private void ShowName()
	{
	}

	[Token(Token = "0x600CD5F")]
	[Address(RVA = "0x30059BC", Offset = "0x30059BC", VA = "0x30059BC")]
	private string GetString(UGCHudWidgetAttributeType attributeType, UGCHudWidgetAttributeEnum attributeEnum = UGCHudWidgetAttributeEnum.None)
	{
		return null;
	}

	[Token(Token = "0x600CD60")]
	[Address(RVA = "0x3006D70", Offset = "0x3006D70", VA = "0x3006D70")]
	private UIUGCHudWidgetAttributeBaseController GetOrCreateAttributeItem(UGCHudWidgetAttributeType attributeType, UGCHudWidgetAttributeEnum attributeEnum)
	{
		return null;
	}

	[Token(Token = "0x600CD61")]
	[Address(RVA = "0x3009D0C", Offset = "0x3009D0C", VA = "0x3009D0C")]
	private UIUGCHudWidgetAttributeBaseController GetAttributeItem(UGCHudWidgetAttributeEnum attributeEnum)
	{
		return null;
	}

	[Token(Token = "0x600CD62")]
	private T GetAttributeItem<T>(UGCHudWidgetAttributeEnum attributeEnum) where T : UIUGCHudWidgetAttributeBaseController
	{
		return null;
	}

	[Token(Token = "0x600CD63")]
	[Address(RVA = "0x3007214", Offset = "0x3007214", VA = "0x3007214")]
	private void BindAttribute(UGCHudWidgetAttributeEnum attributeEnum, UIUGCHudWidgetAttributeBaseController attributeItem, UGCHudWidget widget)
	{
	}

	[Token(Token = "0x600CD64")]
	[Address(RVA = "0x3009DF4", Offset = "0x3009DF4", VA = "0x3009DF4")]
	private void _003COnEditBtnClick_003Em__0(string value)
	{
	}

	[Token(Token = "0x600CD65")]
	[Address(RVA = "0x3009E28", Offset = "0x3009E28", VA = "0x3009E28")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
