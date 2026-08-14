using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using GCommon.UGCUI;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200244B")]
public class UIHUDUGC_CustomHudController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E18F")]
	[FieldOffset(Offset = "0x28")]
	private UGCHudPrefabRoot m_PrefabRoot;

	[Token(Token = "0x400E190")]
	[FieldOffset(Offset = "0x2C")]
	private CustomHudEntity m_ViewData;

	[Token(Token = "0x400E191")]
	[FieldOffset(Offset = "0x30")]
	private UIPanel m_Panel;

	[Token(Token = "0x400E192")]
	[FieldOffset(Offset = "0x34")]
	private UGCHudWidget[] m_Widgets;

	[Token(Token = "0x400E193")]
	[FieldOffset(Offset = "0x38")]
	private List<UIHUDUGC_WidgetBaseController> m_WidgetControllers;

	[Token(Token = "0x400E194")]
	[FieldOffset(Offset = "0x3C")]
	private string m_EntityID;

	[Token(Token = "0x400E195")]
	[FieldOffset(Offset = "0x40")]
	private uint m_HudId;

	[Token(Token = "0x600CE0F")]
	[Address(RVA = "0x222B3DC", Offset = "0x222B3DC", VA = "0x222B3DC")]
	public UIHUDUGC_CustomHudController()
	{
	}

	[Token(Token = "0x600CE10")]
	[Address(RVA = "0x222B494", Offset = "0x222B494", VA = "0x222B494")]
	public static UIHUDUGC_CustomHudController Rebuild(string entityID, Transform parent, int layer)
	{
		return null;
	}

	[Token(Token = "0x600CE11")]
	[Address(RVA = "0x222B6D0", Offset = "0x222B6D0", VA = "0x222B6D0")]
	public static UIHUDUGC_CustomHudController GetOrAdd(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600CE12")]
	[Address(RVA = "0x222B9F8", Offset = "0x222B9F8", VA = "0x222B9F8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CE13")]
	[Address(RVA = "0x222BC24", Offset = "0x222BC24", VA = "0x222BC24")]
	private void InitHudInfo(uint hudID)
	{
	}

	[Token(Token = "0x600CE14")]
	[Address(RVA = "0x222B84C", Offset = "0x222B84C", VA = "0x222B84C", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CE15")]
	[Address(RVA = "0x222BBB0", Offset = "0x222BBB0", VA = "0x222BBB0", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CE16")]
	[Address(RVA = "0x222C574", Offset = "0x222C574", VA = "0x222C574")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CE17")]
	[Address(RVA = "0x222C230", Offset = "0x222C230", VA = "0x222C230")]
	private void OnPrefabIDChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CE18")]
	[Address(RVA = "0x222C150", Offset = "0x222C150", VA = "0x222C150")]
	public UGCHudWidget FindWidget(int widgetId)
	{
		return null;
	}

	[Token(Token = "0x600CE19")]
	[Address(RVA = "0x222C5FC", Offset = "0x222C5FC", VA = "0x222C5FC")]
	public void AddWidgetEntity(UIHUDUGC_WidgetBaseController widgetController)
	{
	}

	[Token(Token = "0x600CE1A")]
	[Address(RVA = "0x222C6D0", Offset = "0x222C6D0", VA = "0x222C6D0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
