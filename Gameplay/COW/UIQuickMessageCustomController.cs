using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200238A")]
public class UIQuickMessageCustomController : UIBaseController, _Attribute
{
	[Token(Token = "0x400DD5A")]
	[FieldOffset(Offset = "0x28")]
	private UIQuickMessageCustomView m_View;

	[Token(Token = "0x600C784")]
	[Address(RVA = "0x1AC23A4", Offset = "0x1AC23A4", VA = "0x1AC23A4")]
	public UIQuickMessageCustomController()
	{
	}

	[Token(Token = "0x600C785")]
	[Address(RVA = "0x1AC2428", Offset = "0x1AC2428", VA = "0x1AC2428", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C786")]
	[Address(RVA = "0x1AC24E4", Offset = "0x1AC24E4", VA = "0x1AC24E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C787")]
	[Address(RVA = "0x1AC258C", Offset = "0x1AC258C", VA = "0x1AC258C", Slot = "32")]
	private void GCommon_002EIEasyList_002ECloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C788")]
	[Address(RVA = "0x1AC2608", Offset = "0x1AC2608", VA = "0x1AC2608", Slot = "31")]
	private UIEasyListItemController GCommon_002EIEasyList_002EOpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C789")]
	[Address(RVA = "0x1AC2700", Offset = "0x1AC2700", VA = "0x1AC2700")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
