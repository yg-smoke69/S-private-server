using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022F3")]
internal class UISceneEditItemAttributePopMenu : UIBaseController, _Attribute
{
	[Token(Token = "0x20022F4")]
	private sealed class _003COnItemSelect_003Ec__AnonStorey0
	{
		[Token(Token = "0x400DA39")]
		[FieldOffset(Offset = "0x8")]
		internal string selectedStr;

		[Token(Token = "0x600C0E5")]
		[Address(RVA = "0x2DA252C", Offset = "0x2DA252C", VA = "0x2DA252C")]
		public _003COnItemSelect_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600C0E6")]
		[Address(RVA = "0x2DA2544", Offset = "0x2DA2544", VA = "0x2DA2544")]
		internal bool _003C_003Em__0(string x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400DA25")]
	[FieldOffset(Offset = "0x28")]
	private UISceneEditItemAttributePopMenuView m_View;

	[Token(Token = "0x400DA26")]
	[FieldOffset(Offset = "0x2C")]
	public Action DataInject;

	[Token(Token = "0x400DA27")]
	[FieldOffset(Offset = "0x30")]
	protected PopUpStyle m_Style;

	[Token(Token = "0x400DA28")]
	[FieldOffset(Offset = "0x34")]
	protected List<PopMenuData> m_DataList;

	[Token(Token = "0x400DA29")]
	[FieldOffset(Offset = "0x38")]
	protected List<UIPopMenuItemSmallController> m_UIPopMenuItemSmallControllerList;

	[Token(Token = "0x400DA2A")]
	[FieldOffset(Offset = "0x3C")]
	protected bool isShowing;

	[Token(Token = "0x400DA2B")]
	[FieldOffset(Offset = "0x40")]
	protected int m_CellWidth;

	[Token(Token = "0x400DA2C")]
	[FieldOffset(Offset = "0x44")]
	protected float m_MaxShowCount;

	[Token(Token = "0x400DA2D")]
	[FieldOffset(Offset = "0x48")]
	protected PopMenuData m_CurrentSelectData;

	[Token(Token = "0x400DA2E")]
	[FieldOffset(Offset = "0x4C")]
	protected bool m_Enable;

	[Token(Token = "0x400DA2F")]
	public const float SPLITLINE = 0.2f;

	[Token(Token = "0x400DA30")]
	public const int SMALLCELLHEIGHT = 38;

	[Token(Token = "0x400DA31")]
	[FieldOffset(Offset = "0x50")]
	protected UIClickMask m_UIClickMask;

	[Token(Token = "0x400DA32")]
	[FieldOffset(Offset = "0x54")]
	private Modifier m_Modifier;

	[Token(Token = "0x400DA33")]
	private const uint DefaultLabelColor = 707736063u;

	[Token(Token = "0x400DA34")]
	[FieldOffset(Offset = "0x58")]
	private List<PopMenuData> m_PopMenuData;

	[Token(Token = "0x400DA35")]
	[FieldOffset(Offset = "0x5C")]
	private Action<object, int> m_ValueChangeCallbackTypeOne;

	[Token(Token = "0x400DA36")]
	[FieldOffset(Offset = "0x60")]
	private List<string> m_OptionTxtKey;

	[Token(Token = "0x400DA37")]
	[FieldOffset(Offset = "0x64")]
	private List<int> m_OptionValues;

	[Token(Token = "0x400DA38")]
	[FieldOffset(Offset = "0x68")]
	private int m_CurOptionIndex;

	[Token(Token = "0x170010A7")]
	private int CurOptionIndex
	{
		[Token(Token = "0x600C0DF")]
		[Address(RVA = "0x2DA1C18", Offset = "0x2DA1C18", VA = "0x2DA1C18")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600C0DE")]
		[Address(RVA = "0x2DA1AF0", Offset = "0x2DA1AF0", VA = "0x2DA1AF0")]
		set
		{
		}
	}

	[Token(Token = "0x600C0CA")]
	[Address(RVA = "0x2D9E778", Offset = "0x2D9E778", VA = "0x2D9E778")]
	public UISceneEditItemAttributePopMenu()
	{
	}

	[Token(Token = "0x600C0CB")]
	[Address(RVA = "0x2D9E848", Offset = "0x2D9E848", VA = "0x2D9E848")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C0CC")]
	[Address(RVA = "0x2D9E8EC", Offset = "0x2D9E8EC", VA = "0x2D9E8EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C0CD")]
	[Address(RVA = "0x2D9EC24", Offset = "0x2D9EC24", VA = "0x2D9EC24")]
	private void InitPopMenu(Action injectDataListAction, ResourceID spriteRes, string Text, PopUpStyle style = PopUpStyle.Down)
	{
	}

	[Token(Token = "0x600C0CE")]
	[Address(RVA = "0x2D9EF80", Offset = "0x2D9EF80", VA = "0x2D9EF80", Slot = "32")]
	public virtual void SetPanelDepth(int depth)
	{
	}

	[Token(Token = "0x600C0CF")]
	[Address(RVA = "0x2D9F088", Offset = "0x2D9F088", VA = "0x2D9F088", Slot = "33")]
	public virtual int GetPanelDepth()
	{
		return default(int);
	}

	[Token(Token = "0x600C0D0")]
	[Address(RVA = "0x2D9F114", Offset = "0x2D9F114", VA = "0x2D9F114", Slot = "34")]
	public virtual void SetEnable(bool enable)
	{
	}

	[Token(Token = "0x600C0D1")]
	[Address(RVA = "0x2D9F2FC", Offset = "0x2D9F2FC", VA = "0x2D9F2FC", Slot = "35")]
	public virtual void UpdateSelectDataInfo(ResourceID spriteRes, string Text = "", string spritename = "")
	{
	}

	[Token(Token = "0x600C0D2")]
	[Address(RVA = "0x2D9EDB0", Offset = "0x2D9EDB0", VA = "0x2D9EDB0")]
	private void SetStyle(PopUpStyle style)
	{
	}

	[Token(Token = "0x600C0D3")]
	[Address(RVA = "0x2D9FA3C", Offset = "0x2D9FA3C", VA = "0x2D9FA3C")]
	public void SetPopViewData(List<PopMenuData> dataList)
	{
	}

	[Token(Token = "0x600C0D4")]
	[Address(RVA = "0x2D9FA9C", Offset = "0x2D9FA9C", VA = "0x2D9FA9C", Slot = "36")]
	protected virtual bool CallDataInject()
	{
		return default(bool);
	}

	[Token(Token = "0x600C0D5")]
	[Address(RVA = "0x2D9FB14", Offset = "0x2D9FB14", VA = "0x2D9FB14", Slot = "37")]
	public virtual void ShowPopUpItem()
	{
	}

	[Token(Token = "0x600C0D6")]
	[Address(RVA = "0x2DA11B4", Offset = "0x2DA11B4", VA = "0x2DA11B4", Slot = "31")]
	public void OnClickeMenuItem(PopMenuData data)
	{
	}

	[Token(Token = "0x600C0D7")]
	[Address(RVA = "0x2DA1364", Offset = "0x2DA1364", VA = "0x2DA1364")]
	private void SetSelectedDataAndClose(object[] data)
	{
	}

	[Token(Token = "0x600C0D8")]
	[Address(RVA = "0x2DA13C0", Offset = "0x2DA13C0", VA = "0x2DA13C0")]
	private void SetSelectedParent(object[] data)
	{
	}

	[Token(Token = "0x600C0D9")]
	[Address(RVA = "0x2DA141C", Offset = "0x2DA141C", VA = "0x2DA141C", Slot = "38")]
	public virtual void SetCurrentSelectData(PopMenuData data)
	{
	}

	[Token(Token = "0x600C0DA")]
	[Address(RVA = "0x2DA14EC", Offset = "0x2DA14EC", VA = "0x2DA14EC")]
	public PopMenuData GetCurrentSelectData()
	{
		return null;
	}

	[Token(Token = "0x600C0DB")]
	[Address(RVA = "0x2DA1544", Offset = "0x2DA1544", VA = "0x2DA1544", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C0DC")]
	[Address(RVA = "0x2DA16FC", Offset = "0x2DA16FC", VA = "0x2DA16FC", Slot = "39")]
	protected virtual void OnPopMenuClose()
	{
	}

	[Token(Token = "0x600C0DD")]
	[Address(RVA = "0x2DA1A90", Offset = "0x2DA1A90", VA = "0x2DA1A90")]
	public void RegisetrValueChangeCallback(Action<object, int> callBack)
	{
	}

	[Token(Token = "0x600C0E0")]
	[Address(RVA = "0x2DA1C70", Offset = "0x2DA1C70", VA = "0x2DA1C70")]
	public void InitShowData(string titleName, List<string> optionTxtKey, List<int> optionValues, int curValue)
	{
	}

	[Token(Token = "0x600C0E1")]
	[Address(RVA = "0x2DA20E4", Offset = "0x2DA20E4", VA = "0x2DA20E4")]
	private void GeneratePopMenuData()
	{
	}

	[Token(Token = "0x600C0E2")]
	[Address(RVA = "0x2DA2350", Offset = "0x2DA2350", VA = "0x2DA2350")]
	private void OnItemSelect(object item)
	{
	}

	[Token(Token = "0x600C0E3")]
	[Address(RVA = "0x2DA2534", Offset = "0x2DA2534", VA = "0x2DA2534")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C0E4")]
	[Address(RVA = "0x2DA253C", Offset = "0x2DA253C", VA = "0x2DA253C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
