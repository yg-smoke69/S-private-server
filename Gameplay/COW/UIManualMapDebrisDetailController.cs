using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002987")]
public class UIManualMapDebrisDetailController : UIPopupWindowController
{
	[Token(Token = "0x400FFC2")]
	[FieldOffset(Offset = "0x48")]
	private UIManualMapDebrisDetailView m_View;

	[Token(Token = "0x400FFC3")]
	[FieldOffset(Offset = "0x4C")]
	private List<UISprite> m_SignList;

	[Token(Token = "0x400FFC4")]
	[FieldOffset(Offset = "0x50")]
	private List<ManualMapData> m_UnlockMapDataList;

	[Token(Token = "0x400FFC5")]
	[FieldOffset(Offset = "0x54")]
	private uint[] m_RadiusArray;

	[Token(Token = "0x400FFC6")]
	[FieldOffset(Offset = "0x58")]
	private bool m_MapHasProcessed;

	[Token(Token = "0x6010AB3")]
	[Address(RVA = "0x2C346DC", Offset = "0x2C346DC", VA = "0x2C346DC")]
	public UIManualMapDebrisDetailController()
	{
	}

	[Token(Token = "0x6010AB4")]
	[Address(RVA = "0x2C347F8", Offset = "0x2C347F8", VA = "0x2C347F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010AB5")]
	[Address(RVA = "0x2C3489C", Offset = "0x2C3489C", VA = "0x2C3489C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010AB6")]
	[Address(RVA = "0x2C349F8", Offset = "0x2C349F8", VA = "0x2C349F8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010AB7")]
	[Address(RVA = "0x2C34A5C", Offset = "0x2C34A5C", VA = "0x2C34A5C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010AB8")]
	[Address(RVA = "0x2C34AC8", Offset = "0x2C34AC8", VA = "0x2C34AC8")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x6010AB9")]
	[Address(RVA = "0x2C32C4C", Offset = "0x2C32C4C", VA = "0x2C32C4C")]
	public void SetData(UIManualMapDebrisController.MapType type, Texture tex, List<ManualMapData> data)
	{
	}

	[Token(Token = "0x6010ABA")]
	[Address(RVA = "0x2C32D18", Offset = "0x2C32D18", VA = "0x2C32D18")]
	public void RefreshView(bool isAllUnlock)
	{
	}

	[Token(Token = "0x6010ABB")]
	[Address(RVA = "0x2C34B2C", Offset = "0x2C34B2C", VA = "0x2C34B2C")]
	private void InitSign(UIManualMapDebrisController.MapType type)
	{
	}

	[Token(Token = "0x6010ABC")]
	[Address(RVA = "0x2C35E94", Offset = "0x2C35E94", VA = "0x2C35E94")]
	private void RefreshSignView()
	{
	}

	[Token(Token = "0x6010ABD")]
	[Address(RVA = "0x2C361B4", Offset = "0x2C361B4", VA = "0x2C361B4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010ABE")]
	[Address(RVA = "0x2C361BC", Offset = "0x2C361BC", VA = "0x2C361BC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010ABF")]
	[Address(RVA = "0x2C361C4", Offset = "0x2C361C4", VA = "0x2C361C4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
