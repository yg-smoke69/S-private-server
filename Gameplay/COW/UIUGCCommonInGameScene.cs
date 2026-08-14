using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200333A")]
internal class UIUGCCommonInGameScene : UIInGameScene
{
	[Token(Token = "0x4013852")]
	[FieldOffset(Offset = "0x2C8")]
	private uint m_HideCSShopDelayCallID;

	[Token(Token = "0x4013853")]
	[FieldOffset(Offset = "0x2CC")]
	private Dictionary<string, IUIHUDBaseController> m_InternalHudControllers;

	[Token(Token = "0x4013854")]
	[FieldOffset(Offset = "0x2D0")]
	private Dictionary<string, UIHUDUGC_CustomHudController> m_CustomHudControllers;

	[Token(Token = "0x4013855")]
	[FieldOffset(Offset = "0x2D4")]
	private Dictionary<string, UIHUDUGC_WidgetBaseController> m_HudWidgetControllers;

	[Token(Token = "0x4013856")]
	[FieldOffset(Offset = "0x2D8")]
	public UIHudUGCDebuggerController UGCDebugHudUI;

	[Token(Token = "0x6015BF4")]
	[Address(RVA = "0x2B863F8", Offset = "0x2B863F8", VA = "0x2B863F8")]
	public UIUGCCommonInGameScene()
	{
	}

	[Token(Token = "0x6015BF5")]
	[Address(RVA = "0x2B86518", Offset = "0x2B86518", VA = "0x2B86518", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015BF6")]
	[Address(RVA = "0x2B86728", Offset = "0x2B86728", VA = "0x2B86728", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015BF7")]
	[Address(RVA = "0x2B869C4", Offset = "0x2B869C4", VA = "0x2B869C4", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015BF8")]
	[Address(RVA = "0x2B86D38", Offset = "0x2B86D38", VA = "0x2B86D38", Slot = "4")]
	public override void Destory()
	{
	}

	[Token(Token = "0x6015BF9")]
	[Address(RVA = "0x2B87084", Offset = "0x2B87084", VA = "0x2B87084")]
	private void OnAddNewEntity(FONLAPPBCOO entityType, string entityID)
	{
	}

	[Token(Token = "0x6015BFA")]
	[Address(RVA = "0x2B88C10", Offset = "0x2B88C10", VA = "0x2B88C10")]
	private void OnRemoveEntity(FONLAPPBCOO entityType, string entityID)
	{
	}

	[Token(Token = "0x6015BFB")]
	[Address(RVA = "0x2B88EFC", Offset = "0x2B88EFC", VA = "0x2B88EFC")]
	private void OnStartNewPhase(object[] param)
	{
	}

	[Token(Token = "0x6015BFC")]
	[Address(RVA = "0x2B8914C", Offset = "0x2B8914C", VA = "0x2B8914C")]
	private void OnStartNewRound(object[] data)
	{
	}

	[Token(Token = "0x6015BFD")]
	[Address(RVA = "0x2B891A8", Offset = "0x2B891A8", VA = "0x2B891A8")]
	private void OnMatchEndShowResult(object[] data)
	{
	}

	[Token(Token = "0x6015BFE")]
	[Address(RVA = "0x2B89298", Offset = "0x2B89298", VA = "0x2B89298", Slot = "34")]
	protected override bool IsNeedSafeZoneInfoController()
	{
		return default(bool);
	}

	[Token(Token = "0x6015BFF")]
	[Address(RVA = "0x2B892F0", Offset = "0x2B892F0", VA = "0x2B892F0", Slot = "29")]
	protected override bool IsNeedDirectionRuler()
	{
		return default(bool);
	}

	[Token(Token = "0x6015C00")]
	[Address(RVA = "0x2B89348", Offset = "0x2B89348", VA = "0x2B89348")]
	public UIHUDUGC_CustomHudController GetCustomHud(string entityId)
	{
		return null;
	}

	[Token(Token = "0x6015C01")]
	[Address(RVA = "0x2B89430", Offset = "0x2B89430", VA = "0x2B89430")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015C02")]
	[Address(RVA = "0x2B89438", Offset = "0x2B89438", VA = "0x2B89438")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015C03")]
	[Address(RVA = "0x2B89440", Offset = "0x2B89440", VA = "0x2B89440")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015C04")]
	[Address(RVA = "0x2B89448", Offset = "0x2B89448", VA = "0x2B89448")]
	public new void _003C_003EiFixBaseProxy_Destory()
	{
	}

	[Token(Token = "0x6015C05")]
	[Address(RVA = "0x2B89450", Offset = "0x2B89450", VA = "0x2B89450")]
	public bool _003C_003EiFixBaseProxy_IsNeedSafeZoneInfoController()
	{
		return default(bool);
	}

	[Token(Token = "0x6015C06")]
	[Address(RVA = "0x2B89458", Offset = "0x2B89458", VA = "0x2B89458")]
	public bool _003C_003EiFixBaseProxy_IsNeedDirectionRuler()
	{
		return default(bool);
	}
}
