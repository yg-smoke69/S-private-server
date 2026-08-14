using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002511")]
public class UIChatRecruitContainerController : UIChatBaseContainerController, _Attribute, IConvertible
{
	[Token(Token = "0x400E5FF")]
	[FieldOffset(Offset = "0x28")]
	private UIChatRecruitContainerView m_View;

	[Token(Token = "0x400E600")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x400E601")]
	[FieldOffset(Offset = "0x30")]
	private UIModelChat m_ModelChat;

	[Token(Token = "0x400E602")]
	[FieldOffset(Offset = "0x34")]
	private float m_EasyListOffsetY;

	[Token(Token = "0x600D71A")]
	[Address(RVA = "0x2073B10", Offset = "0x2073B10", VA = "0x2073B10")]
	public UIChatRecruitContainerController()
	{
	}

	[Token(Token = "0x600D71B")]
	[Address(RVA = "0x2073B24", Offset = "0x2073B24", VA = "0x2073B24", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D71C")]
	[Address(RVA = "0x2074020", Offset = "0x2074020", VA = "0x2074020")]
	private void OnRecruitItemClick(object[] data)
	{
	}

	[Token(Token = "0x600D71D")]
	[Address(RVA = "0x2074618", Offset = "0x2074618", VA = "0x2074618", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D71E")]
	[Address(RVA = "0x2074794", Offset = "0x2074794", VA = "0x2074794")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D71F")]
	[Address(RVA = "0x2074838", Offset = "0x2074838", VA = "0x2074838", Slot = "31")]
	public override GameObject GetContentNode()
	{
		return null;
	}

	[Token(Token = "0x600D720")]
	[Address(RVA = "0x20748A8", Offset = "0x20748A8", VA = "0x20748A8", Slot = "32")]
	public override GameObject GetEmptyNode()
	{
		return null;
	}

	[Token(Token = "0x600D721")]
	[Address(RVA = "0x2074918", Offset = "0x2074918", VA = "0x2074918", Slot = "33")]
	public override UIScrollView GetMessageList()
	{
		return null;
	}

	[Token(Token = "0x600D722")]
	[Address(RVA = "0x2074988", Offset = "0x2074988", VA = "0x2074988", Slot = "34")]
	public override void InitWidget(Transform parent)
	{
	}

	[Token(Token = "0x600D723")]
	[Address(RVA = "0x2074A70", Offset = "0x2074A70", VA = "0x2074A70", Slot = "35")]
	public override void RefreshContentNode()
	{
	}

	[Token(Token = "0x600D724")]
	[Address(RVA = "0x2074248", Offset = "0x2074248", VA = "0x2074248")]
	private void RefreshMessageList()
	{
	}

	[Token(Token = "0x600D725")]
	[Address(RVA = "0x2074AD8", Offset = "0x2074AD8", VA = "0x2074AD8")]
	private void RefreshGroupInfo()
	{
	}

	[Token(Token = "0x600D726")]
	[Address(RVA = "0x2075158", Offset = "0x2075158", VA = "0x2075158")]
	private void OnRecruitClick()
	{
	}

	[Token(Token = "0x600D727")]
	[Address(RVA = "0x207588C", Offset = "0x207588C", VA = "0x207588C")]
	private void OnLeaveGroupBtnClick()
	{
	}

	[Token(Token = "0x600D728")]
	[Address(RVA = "0x2075998", Offset = "0x2075998", VA = "0x2075998", Slot = "36")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D729")]
	[Address(RVA = "0x2075AEC", Offset = "0x2075AEC", VA = "0x2075AEC", Slot = "37")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D72A")]
	[Address(RVA = "0x2075BA4", Offset = "0x2075BA4", VA = "0x2075BA4", Slot = "38")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D72B")]
	[Address(RVA = "0x2075C9C", Offset = "0x2075C9C", VA = "0x2075C9C", Slot = "39")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D72C")]
	[Address(RVA = "0x2075D18", Offset = "0x2075D18", VA = "0x2075D18")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D72D")]
	[Address(RVA = "0x2075D20", Offset = "0x2075D20", VA = "0x2075D20")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600D72E")]
	[Address(RVA = "0x2075D28", Offset = "0x2075D28", VA = "0x2075D28")]
	public void _003C_003EiFixBaseProxy_InitWidget(Transform P0)
	{
	}
}
