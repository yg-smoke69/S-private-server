using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029DC")]
internal class UINaviPopController : UINavigationController
{
	[Token(Token = "0x4010169")]
	[FieldOffset(Offset = "0x68")]
	protected bool m_NaviMaskState;

	[Token(Token = "0x401016A")]
	[FieldOffset(Offset = "0x6C")]
	protected GameObject m_NaviMask;

	[Token(Token = "0x6010D95")]
	[Address(RVA = "0x1B27B20", Offset = "0x1B27B20", VA = "0x1B27B20")]
	public UINaviPopController()
	{
	}

	[Token(Token = "0x6010D96")]
	[Address(RVA = "0x1B287E0", Offset = "0x1B287E0", VA = "0x1B287E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010D97")]
	[Address(RVA = "0x1B29414", Offset = "0x1B29414", VA = "0x1B29414", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010D98")]
	[Address(RVA = "0x1B30B8C", Offset = "0x1B30B8C", VA = "0x1B30B8C", Slot = "42")]
	protected virtual void OnClickClose()
	{
	}

	[Token(Token = "0x6010D99")]
	[Address(RVA = "0x1B30C98", Offset = "0x1B30C98", VA = "0x1B30C98", Slot = "40")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x6010D9A")]
	[Address(RVA = "0x1B30CF0", Offset = "0x1B30CF0", VA = "0x1B30CF0", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6010D9B")]
	[Address(RVA = "0x1B31CE8", Offset = "0x1B31CE8", VA = "0x1B31CE8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010D9C")]
	[Address(RVA = "0x1B31CF0", Offset = "0x1B31CF0", VA = "0x1B31CF0")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6010D9D")]
	[Address(RVA = "0x1B31CF4", Offset = "0x1B31CF4", VA = "0x1B31CF4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6010D9E")]
	[Address(RVA = "0x1B31CFC", Offset = "0x1B31CFC", VA = "0x1B31CFC")]
	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}
}
