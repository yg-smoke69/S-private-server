using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024BD")]
public class UIAvatarPopMenuController : UIBasePopMenuController<UIAvatarPopMenuItemContoller>
{
	[Token(Token = "0x400E3D5")]
	[FieldOffset(Offset = "0x84")]
	private Action m_OnDestroyCallback;

	[Token(Token = "0x600D2FB")]
	[Address(RVA = "0x2B5D6B0", Offset = "0x2B5D6B0", VA = "0x2B5D6B0")]
	public UIAvatarPopMenuController()
	{
	}

	[Token(Token = "0x600D2FC")]
	[Address(RVA = "0x2B5D714", Offset = "0x2B5D714", VA = "0x2B5D714")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D2FD")]
	[Address(RVA = "0x2B5D7B8", Offset = "0x2B5D7B8", VA = "0x2B5D7B8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D2FE")]
	[Address(RVA = "0x2B5D8E0", Offset = "0x2B5D8E0", VA = "0x2B5D8E0")]
	public void OnGroupQuit(object[] data)
	{
	}

	[Token(Token = "0x600D2FF")]
	[Address(RVA = "0x2B5D94C", Offset = "0x2B5D94C", VA = "0x2B5D94C")]
	public void SetData(List<CommonPopMenuData> list, [Optional] Action onDestroy)
	{
	}

	[Token(Token = "0x600D300")]
	[Address(RVA = "0x2B5DA20", Offset = "0x2B5DA20", VA = "0x2B5DA20", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D301")]
	[Address(RVA = "0x2B5DA98", Offset = "0x2B5DA98", VA = "0x2B5DA98")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D302")]
	[Address(RVA = "0x2B5DA9C", Offset = "0x2B5DA9C", VA = "0x2B5DA9C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
