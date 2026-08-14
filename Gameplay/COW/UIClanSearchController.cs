using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002552")]
public class UIClanSearchController : UINavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x400E723")]
	[FieldOffset(Offset = "0x68")]
	private UIClanSearchView m_View;

	[Token(Token = "0x400E724")]
	private const int COOLDOWN_SECONDS = 30;

	[Token(Token = "0x400E725")]
	[FieldOffset(Offset = "0x6C")]
	private CountDownConfig config;

	[Token(Token = "0x400E726")]
	[FieldOffset(Offset = "0x70")]
	private int CLAN_ID_LENGTH_MIN;

	[Token(Token = "0x400E727")]
	private const int FILTER_COUNTDOWN_SECONDS = 30;

	[Token(Token = "0x400E728")]
	[FieldOffset(Offset = "0x74")]
	private uint m_FilterCallID;

	[Token(Token = "0x400E729")]
	[FieldOffset(Offset = "0x78")]
	private string m_regionSelected;

	[Token(Token = "0x400E72A")]
	[FieldOffset(Offset = "0x7C")]
	private string m_styleSelected;

	[Token(Token = "0x400E72B")]
	[FieldOffset(Offset = "0x80")]
	private string[] m_SloganLabels;

	[Token(Token = "0x400E72C")]
	[FieldOffset(Offset = "0x84")]
	private uint m_PlayStyle;

	[Token(Token = "0x400E72D")]
	[FieldOffset(Offset = "0x88")]
	private uint m_Area;

	[Token(Token = "0x400E72E")]
	[FieldOffset(Offset = "0x8C")]
	private int m_CurSloganIndex;

	[Token(Token = "0x400E72F")]
	[FieldOffset(Offset = "0x90")]
	private List<UIClanListItemController> m_Items;

	[Token(Token = "0x400E730")]
	[FieldOffset(Offset = "0x0")]
	private static Callback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600D978")]
	[Address(RVA = "0x2B4376C", Offset = "0x2B4376C", VA = "0x2B4376C")]
	public UIClanSearchController()
	{
	}

	[Token(Token = "0x600D979")]
	[Address(RVA = "0x2B439DC", Offset = "0x2B439DC", VA = "0x2B439DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D97A")]
	[Address(RVA = "0x2B43A80", Offset = "0x2B43A80", VA = "0x2B43A80", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D97B")]
	[Address(RVA = "0x2B44C44", Offset = "0x2B44C44", VA = "0x2B44C44", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D97C")]
	[Address(RVA = "0x2B44E4C", Offset = "0x2B44E4C", VA = "0x2B44E4C")]
	private void OnClickSwitchLeft()
	{
	}

	[Token(Token = "0x600D97D")]
	[Address(RVA = "0x2B44EC0", Offset = "0x2B44EC0", VA = "0x2B44EC0")]
	private void OnClickSwitchRight()
	{
	}

	[Token(Token = "0x600D97E")]
	[Address(RVA = "0x2B448AC", Offset = "0x2B448AC", VA = "0x2B448AC")]
	private void OnChangeLabelType()
	{
	}

	[Token(Token = "0x600D97F")]
	[Address(RVA = "0x2B44F54", Offset = "0x2B44F54", VA = "0x2B44F54")]
	private void OnClickFilter()
	{
	}

	[Token(Token = "0x600D980")]
	[Address(RVA = "0x2B45390", Offset = "0x2B45390", VA = "0x2B45390")]
	private void OnSearchPopMenuClick(object[] data)
	{
	}

	[Token(Token = "0x600D981")]
	[Address(RVA = "0x2B454AC", Offset = "0x2B454AC", VA = "0x2B454AC")]
	private void OnChoose()
	{
	}

	[Token(Token = "0x600D982")]
	[Address(RVA = "0x2B44454", Offset = "0x2B44454", VA = "0x2B44454")]
	private void FilterCountDown()
	{
	}

	[Token(Token = "0x600D983")]
	[Address(RVA = "0x2B44300", Offset = "0x2B44300", VA = "0x2B44300")]
	private void InFilterCDTime(bool isInTime)
	{
	}

	[Token(Token = "0x600D984")]
	[Address(RVA = "0x2B457F0", Offset = "0x2B457F0", VA = "0x2B457F0")]
	private void OnFilterClanList()
	{
	}

	[Token(Token = "0x600D985")]
	[Address(RVA = "0x2B45958", Offset = "0x2B45958", VA = "0x2B45958", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D986")]
	[Address(RVA = "0x2B45F7C", Offset = "0x2B45F7C", VA = "0x2B45F7C", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D987")]
	private void RefreshClanList<DataType>(List<DataType> clanList)
	{
	}

	[Token(Token = "0x600D988")]
	[Address(RVA = "0x2B45C8C", Offset = "0x2B45C8C", VA = "0x2B45C8C")]
	private void ShowApplyReply()
	{
	}

	[Token(Token = "0x600D989")]
	[Address(RVA = "0x2B46014", Offset = "0x2B46014", VA = "0x2B46014")]
	private void OnBtnClanCreated()
	{
	}

	[Token(Token = "0x600D98A")]
	[Address(RVA = "0x2B46330", Offset = "0x2B46330", VA = "0x2B46330")]
	private void OnBtnClanRefresh()
	{
	}

	[Token(Token = "0x600D98B")]
	[Address(RVA = "0x2B46774", Offset = "0x2B46774", VA = "0x2B46774")]
	private void OnCountDownStarted()
	{
	}

	[Token(Token = "0x600D98C")]
	[Address(RVA = "0x2B44784", Offset = "0x2B44784", VA = "0x2B44784")]
	private void OnCountDownFinished()
	{
	}

	[Token(Token = "0x600D98D")]
	[Address(RVA = "0x2B4689C", Offset = "0x2B4689C", VA = "0x2B4689C")]
	private void OnBtnClanSearch()
	{
	}

	[Token(Token = "0x600D98E")]
	[Address(RVA = "0x2B46CB8", Offset = "0x2B46CB8", VA = "0x2B46CB8")]
	public void SearchClanById(string clanId)
	{
	}

	[Token(Token = "0x600D98F")]
	[Address(RVA = "0x2B46D58", Offset = "0x2B46D58", VA = "0x2B46D58")]
	private void OnInputChanged()
	{
	}

	[Token(Token = "0x600D990")]
	[Address(RVA = "0x2B46E68", Offset = "0x2B46E68", VA = "0x2B46E68")]
	private void OnBtnInputClear()
	{
	}

	[Token(Token = "0x600D991")]
	[Address(RVA = "0x2B46F78", Offset = "0x2B46F78", VA = "0x2B46F78", Slot = "44")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D992")]
	[Address(RVA = "0x2B470A8", Offset = "0x2B470A8", VA = "0x2B470A8", Slot = "45")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D993")]
	[Address(RVA = "0x2B47254", Offset = "0x2B47254", VA = "0x2B47254")]
	private static void _003COnBtnClanCreated_003Em__0()
	{
	}

	[Token(Token = "0x600D994")]
	[Address(RVA = "0x2B47370", Offset = "0x2B47370", VA = "0x2B47370")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D995")]
	[Address(RVA = "0x2B47378", Offset = "0x2B47378", VA = "0x2B47378")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
