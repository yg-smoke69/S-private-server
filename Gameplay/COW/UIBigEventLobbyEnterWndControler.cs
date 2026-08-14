using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001F85")]
public class UIBigEventLobbyEnterWndControler : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400C5D4")]
	[FieldOffset(Offset = "0x48")]
	private UIBigEventLobbyEnterWndView m_View;

	[Token(Token = "0x400C5D5")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C5D6")]
	[FieldOffset(Offset = "0x50")]
	private BigEventOpenInfoDesc m_BigEventOpenInfo;

	[Token(Token = "0x400C5D7")]
	[FieldOffset(Offset = "0x54")]
	private BigEventEntryDesc m_DescData;

	[Token(Token = "0x400C5D8")]
	private const uint MAIN_ENTRY_DESC_INDEX = 1u;

	[Token(Token = "0x400C5D9")]
	[FieldOffset(Offset = "0x58")]
	protected Transform ItemRoot;

	[Token(Token = "0x400C5DA")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<BigEventEntryDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6009CA1")]
	[Address(RVA = "0x300DE14", Offset = "0x300DE14", VA = "0x300DE14")]
	public UIBigEventLobbyEnterWndControler()
	{
	}

	[Token(Token = "0x6009CA2")]
	[Address(RVA = "0x300DE1C", Offset = "0x300DE1C", VA = "0x300DE1C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009CA3")]
	[Address(RVA = "0x300DEC4", Offset = "0x300DEC4", VA = "0x300DEC4", Slot = "48")]
	public virtual UIBigEventLobbyEnterItemControler GetLobbyEnterItem()
	{
		return null;
	}

	[Token(Token = "0x6009CA4")]
	[Address(RVA = "0x300DFEC", Offset = "0x300DFEC", VA = "0x300DFEC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009CA5")]
	[Address(RVA = "0x300E234", Offset = "0x300E234", VA = "0x300E234", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6009CA6")]
	[Address(RVA = "0x300E7FC", Offset = "0x300E7FC", VA = "0x300E7FC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009CA7")]
	[Address(RVA = "0x300E860", Offset = "0x300E860", VA = "0x300E860", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6009CA8")]
	[Address(RVA = "0x300E8C4", Offset = "0x300E8C4", VA = "0x300E8C4", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6009CA9")]
	[Address(RVA = "0x300E938", Offset = "0x300E938", VA = "0x300E938", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6009CAA")]
	[Address(RVA = "0x300E9B4", Offset = "0x300E9B4", VA = "0x300E9B4")]
	private static bool _003COnUIOpen_003Em__0(BigEventEntryDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x6009CAB")]
	[Address(RVA = "0x300E9E0", Offset = "0x300E9E0", VA = "0x300E9E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009CAC")]
	[Address(RVA = "0x300E9E8", Offset = "0x300E9E8", VA = "0x300E9E8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6009CAD")]
	[Address(RVA = "0x300E9F0", Offset = "0x300E9F0", VA = "0x300E9F0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6009CAE")]
	[Address(RVA = "0x300E9F8", Offset = "0x300E9F8", VA = "0x300E9F8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
