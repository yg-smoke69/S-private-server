using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002509")]
public class UIChatClanContainerController : UIChatBaseContainerController, _Attribute
{
	[Token(Token = "0x400E5EA")]
	[FieldOffset(Offset = "0x28")]
	private UIChatClanContainerView m_View;

	[Token(Token = "0x400E5EB")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_HideLuckyBagCallID;

	[Token(Token = "0x600D6B3")]
	[Address(RVA = "0x262CEA8", Offset = "0x262CEA8", VA = "0x262CEA8")]
	public UIChatClanContainerController()
	{
	}

	[Token(Token = "0x600D6B4")]
	[Address(RVA = "0x262CEAC", Offset = "0x262CEAC", VA = "0x262CEAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D6B5")]
	[Address(RVA = "0x262CF50", Offset = "0x262CF50", VA = "0x262CF50", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D6B6")]
	[Address(RVA = "0x262D208", Offset = "0x262D208", VA = "0x262D208", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D6B7")]
	[Address(RVA = "0x262D37C", Offset = "0x262D37C", VA = "0x262D37C", Slot = "31")]
	public override GameObject GetContentNode()
	{
		return null;
	}

	[Token(Token = "0x600D6B8")]
	[Address(RVA = "0x262D3EC", Offset = "0x262D3EC", VA = "0x262D3EC", Slot = "32")]
	public override GameObject GetEmptyNode()
	{
		return null;
	}

	[Token(Token = "0x600D6B9")]
	[Address(RVA = "0x262D45C", Offset = "0x262D45C", VA = "0x262D45C", Slot = "33")]
	public override UIScrollView GetMessageList()
	{
		return null;
	}

	[Token(Token = "0x600D6BA")]
	[Address(RVA = "0x262D4CC", Offset = "0x262D4CC", VA = "0x262D4CC", Slot = "35")]
	public override void RefreshContentNode()
	{
	}

	[Token(Token = "0x600D6BB")]
	[Address(RVA = "0x262D708", Offset = "0x262D708", VA = "0x262D708", Slot = "34")]
	public override void InitWidget(Transform parent)
	{
	}

	[Token(Token = "0x600D6BC")]
	[Address(RVA = "0x262D7EC", Offset = "0x262D7EC", VA = "0x262D7EC")]
	private void OnGotoSearchClanClick()
	{
	}

	[Token(Token = "0x600D6BD")]
	[Address(RVA = "0x262D8D4", Offset = "0x262D8D4", VA = "0x262D8D4")]
	private void OnGotoLuckyBag()
	{
	}

	[Token(Token = "0x600D6BE")]
	[Address(RVA = "0x262DA78", Offset = "0x262DA78", VA = "0x262DA78")]
	private void ShowLuckyBagMessage(ClanLuckyBag lb)
	{
	}

	[Token(Token = "0x600D6BF")]
	[Address(RVA = "0x262DAD4", Offset = "0x262DAD4", VA = "0x262DAD4", Slot = "36")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D6C0")]
	[Address(RVA = "0x262DC28", Offset = "0x262DC28", VA = "0x262DC28", Slot = "37")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D6C1")]
	[Address(RVA = "0x262DCBC", Offset = "0x262DCBC", VA = "0x262DCBC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D6C2")]
	[Address(RVA = "0x262DCC4", Offset = "0x262DCC4", VA = "0x262DCC4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600D6C3")]
	[Address(RVA = "0x262DCCC", Offset = "0x262DCCC", VA = "0x262DCCC")]
	public void _003C_003EiFixBaseProxy_InitWidget(Transform P0)
	{
	}
}
