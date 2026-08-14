using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002305")]
internal class UIRuleHTabsPanelController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002306")]
	public class TabData
	{
		[Token(Token = "0x400DA85")]
		[FieldOffset(Offset = "0x8")]
		public string Label;

		[Token(Token = "0x400DA86")]
		[FieldOffset(Offset = "0xC")]
		public string SubLabel;

		[Token(Token = "0x400DA87")]
		[FieldOffset(Offset = "0x10")]
		public int Index;

		[Token(Token = "0x400DA88")]
		[FieldOffset(Offset = "0x14")]
		public int ComponentIndex;

		[Token(Token = "0x600C172")]
		[Address(RVA = "0x2BF5690", Offset = "0x2BF5690", VA = "0x2BF5690")]
		public TabData()
		{
		}
	}

	[Token(Token = "0x400DA7E")]
	[FieldOffset(Offset = "0x28")]
	private UIRuleHTabsPanelView m_View;

	[Token(Token = "0x400DA7F")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelUGCModeEdit m_Model;

	[Token(Token = "0x400DA80")]
	[FieldOffset(Offset = "0x30")]
	private List<UIBaseController> m_Components;

	[Token(Token = "0x400DA81")]
	[FieldOffset(Offset = "0x34")]
	private int m_CurrentComponentIndex;

	[Token(Token = "0x400DA82")]
	[FieldOffset(Offset = "0x38")]
	private List<TabData> m_TabData;

	[Token(Token = "0x400DA83")]
	[FieldOffset(Offset = "0x3C")]
	private float m_Width;

	[Token(Token = "0x400DA84")]
	[FieldOffset(Offset = "0x40")]
	public CHTabsPanelData Data;

	[Token(Token = "0x600C162")]
	[Address(RVA = "0x2BF464C", Offset = "0x2BF464C", VA = "0x2BF464C")]
	public UIRuleHTabsPanelController()
	{
	}

	[Token(Token = "0x600C163")]
	[Address(RVA = "0x2BF4738", Offset = "0x2BF4738", VA = "0x2BF4738")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C164")]
	[Address(RVA = "0x2BF47E0", Offset = "0x2BF47E0", VA = "0x2BF47E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C165")]
	[Address(RVA = "0x2BF49A0", Offset = "0x2BF49A0", VA = "0x2BF49A0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600C166")]
	[Address(RVA = "0x2BF4A04", Offset = "0x2BF4A04", VA = "0x2BF4A04", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C167")]
	[Address(RVA = "0x2BF4A68", Offset = "0x2BF4A68", VA = "0x2BF4A68", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C168")]
	[Address(RVA = "0x2BF4C04", Offset = "0x2BF4C04", VA = "0x2BF4C04")]
	public void SetViewData(CHTabsPanelData data, float width)
	{
	}

	[Token(Token = "0x600C169")]
	[Address(RVA = "0x2BF5698", Offset = "0x2BF5698", VA = "0x2BF5698")]
	private void BuildChildComponent(Transform container, IModeEditComponentData data, TabData tabData)
	{
	}

	[Token(Token = "0x600C16A")]
	[Address(RVA = "0x2BF595C", Offset = "0x2BF595C", VA = "0x2BF595C")]
	private void OnSelectTab(object[] param)
	{
	}

	[Token(Token = "0x600C16B")]
	[Address(RVA = "0x2BF5D1C", Offset = "0x2BF5D1C", VA = "0x2BF5D1C")]
	private void OnItemIndexChanged()
	{
	}

	[Token(Token = "0x600C16C")]
	[Address(RVA = "0x2BF6054", Offset = "0x2BF6054", VA = "0x2BF6054", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C16D")]
	[Address(RVA = "0x2BF614C", Offset = "0x2BF614C", VA = "0x2BF614C", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C16E")]
	[Address(RVA = "0x2BF61C8", Offset = "0x2BF61C8", VA = "0x2BF61C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C16F")]
	[Address(RVA = "0x2BF61D0", Offset = "0x2BF61D0", VA = "0x2BF61D0")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600C170")]
	[Address(RVA = "0x2BF61D8", Offset = "0x2BF61D8", VA = "0x2BF61D8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600C171")]
	[Address(RVA = "0x2BF61E0", Offset = "0x2BF61E0", VA = "0x2BF61E0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
