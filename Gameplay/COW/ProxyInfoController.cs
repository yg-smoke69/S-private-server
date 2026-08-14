using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20022AD")]
public class ProxyInfoController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400D8FF")]
	[FieldOffset(Offset = "0x48")]
	private ProxyInfoView m_View;

	[Token(Token = "0x400D900")]
	[FieldOffset(Offset = "0x4C")]
	private List<ProxyInfoListItemController> m_Items;

	[Token(Token = "0x400D901")]
	[FieldOffset(Offset = "0x50")]
	private Queue<HttpRequest> m_RecordRequestList;

	[Token(Token = "0x600BEA2")]
	[Address(RVA = "0x196ABDC", Offset = "0x196ABDC", VA = "0x196ABDC")]
	public ProxyInfoController()
	{
	}

	[Token(Token = "0x600BEA3")]
	[Address(RVA = "0x196AC9C", Offset = "0x196AC9C", VA = "0x196AC9C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BEA4")]
	[Address(RVA = "0x196AD40", Offset = "0x196AD40", VA = "0x196AD40", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BEA5")]
	[Address(RVA = "0x196AF34", Offset = "0x196AF34", VA = "0x196AF34", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BEA6")]
	[Address(RVA = "0x196B134", Offset = "0x196B134", VA = "0x196B134")]
	public void InitData()
	{
	}

	[Token(Token = "0x600BEA7")]
	[Address(RVA = "0x196B254", Offset = "0x196B254", VA = "0x196B254", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600BEA8")]
	[Address(RVA = "0x196B400", Offset = "0x196B400", VA = "0x196B400", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600BEA9")]
	[Address(RVA = "0x196B530", Offset = "0x196B530", VA = "0x196B530")]
	private void AddRequest(object[] data)
	{
	}

	[Token(Token = "0x600BEAA")]
	[Address(RVA = "0x196B6E8", Offset = "0x196B6E8", VA = "0x196B6E8")]
	public void Reset()
	{
	}

	[Token(Token = "0x600BEAB")]
	[Address(RVA = "0x196B834", Offset = "0x196B834", VA = "0x196B834")]
	private void RemoveRequest(object[] data)
	{
	}

	[Token(Token = "0x600BEAC")]
	[Address(RVA = "0x196BADC", Offset = "0x196BADC", VA = "0x196BADC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BEAD")]
	[Address(RVA = "0x196BAE4", Offset = "0x196BAE4", VA = "0x196BAE4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
