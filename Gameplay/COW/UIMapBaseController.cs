using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200226F")]
public class UIMapBaseController : UIBaseController
{
	[Token(Token = "0x400D740")]
	[FieldOffset(Offset = "0x28")]
	protected UIMapContentController m_MapContentCtrl;

	[Token(Token = "0x600BC07")]
	[Address(RVA = "0x123A3CC", Offset = "0x123A3CC", VA = "0x123A3CC")]
	public UIMapBaseController()
	{
	}

	[Token(Token = "0x600BC08")]
	[Address(RVA = "0x123A450", Offset = "0x123A450", VA = "0x123A450", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BC09")]
	[Address(RVA = "0x123A4B4", Offset = "0x123A4B4", VA = "0x123A4B4")]
	protected void InitMapContent(Transform tr, UIMapUtil.EMapType mapType = UIMapUtil.EMapType.Minimap)
	{
	}

	[Token(Token = "0x600BC0A")]
	[Address(RVA = "0x123AFC8", Offset = "0x123AFC8", VA = "0x123AFC8", Slot = "31")]
	protected virtual void RegisterEvents()
	{
	}

	[Token(Token = "0x600BC0B")]
	[Address(RVA = "0x123B1B8", Offset = "0x123B1B8", VA = "0x123B1B8", Slot = "32")]
	protected virtual void UnRegisterEvents()
	{
	}

	[Token(Token = "0x600BC0C")]
	[Address(RVA = "0x123B3A8", Offset = "0x123B3A8", VA = "0x123B3A8", Slot = "33")]
	protected virtual void OnObservePlayer(object[] data)
	{
	}

	[Token(Token = "0x600BC0D")]
	[Address(RVA = "0x123B404", Offset = "0x123B404", VA = "0x123B404", Slot = "34")]
	protected virtual void OnObserverTargetChange(object[] data)
	{
	}

	[Token(Token = "0x600BC0E")]
	[Address(RVA = "0x123B668", Offset = "0x123B668", VA = "0x123B668", Slot = "35")]
	protected virtual void OnPlayerHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600BC0F")]
	[Address(RVA = "0x123B6C4", Offset = "0x123B6C4", VA = "0x123B6C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
