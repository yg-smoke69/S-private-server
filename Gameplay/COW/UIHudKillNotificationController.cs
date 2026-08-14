using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027A2")]
internal class UIHudKillNotificationController : UIBaseController, _Attribute
{
	[Token(Token = "0x400F4A9")]
	[FieldOffset(Offset = "0x28")]
	private UIHudKillNotificationView m_View;

	[Token(Token = "0x400F4AA")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudKillNotificationItem[] m_Items;

	[Token(Token = "0x400F4AB")]
	[FieldOffset(Offset = "0x30")]
	private UIHudKillNotificationItem[] m_MiniItems;

	[Token(Token = "0x400F4AC")]
	[FieldOffset(Offset = "0x34")]
	private UIWeaponKillNotificationItemController m_WeaponKillNotification;

	[Token(Token = "0x400F4AD")]
	[FieldOffset(Offset = "0x38")]
	private UIModelMatch m_MatchModel;

	[Token(Token = "0x400F4AE")]
	[FieldOffset(Offset = "0x3C")]
	private Queue<PendingNotification> m_PendingNotificationRegular;

	[Token(Token = "0x400F4AF")]
	[FieldOffset(Offset = "0x40")]
	private Queue<PendingNotification> m_PendingNotificationWeaponWithSkin;

	[Token(Token = "0x400F4B0")]
	[FieldOffset(Offset = "0x44")]
	private Queue<PendingNotification> m_PendingNotificationPool;

	[Token(Token = "0x400F4B1")]
	[FieldOffset(Offset = "0x48")]
	private Timer m_AddNotificationCoolDown;

	[Token(Token = "0x400F4B2")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<ushort, string> m_LevelToTipsLoc;

	[Token(Token = "0x400F4B3")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsMiniTips;

	[Token(Token = "0x400F4B4")]
	[FieldOffset(Offset = "0x54")]
	private int m_TeamColor;

	[Token(Token = "0x400F4B5")]
	[FieldOffset(Offset = "0x58")]
	private UIBaseController m_HudCoveredBy;

	[Token(Token = "0x600F456")]
	[Address(RVA = "0x1BB3AFC", Offset = "0x1BB3AFC", VA = "0x1BB3AFC")]
	public UIHudKillNotificationController()
	{
	}

	[Token(Token = "0x600F457")]
	[Address(RVA = "0x1BB3C34", Offset = "0x1BB3C34", VA = "0x1BB3C34")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F458")]
	[Address(RVA = "0x1BB3CD8", Offset = "0x1BB3CD8", VA = "0x1BB3CD8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F459")]
	[Address(RVA = "0x1BB4AA8", Offset = "0x1BB4AA8", VA = "0x1BB4AA8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F45A")]
	[Address(RVA = "0x1BB4DE4", Offset = "0x1BB4DE4", VA = "0x1BB4DE4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F45B")]
	[Address(RVA = "0x1BB4FA4", Offset = "0x1BB4FA4", VA = "0x1BB4FA4")]
	public void SetHudCoveredBy(UIBaseController ctrl)
	{
	}

	[Token(Token = "0x600F45C")]
	[Address(RVA = "0x1BB5004", Offset = "0x1BB5004", VA = "0x1BB5004")]
	private void Update()
	{
	}

	[Token(Token = "0x600F45D")]
	[Address(RVA = "0x1BB5A6C", Offset = "0x1BB5A6C", VA = "0x1BB5A6C")]
	private void OnHypeLevelChanged(object[] data)
	{
	}

	[Token(Token = "0x600F45E")]
	[Address(RVA = "0x1BB5E20", Offset = "0x1BB5E20", VA = "0x1BB5E20", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600F45F")]
	[Address(RVA = "0x1BB8BF4", Offset = "0x1BB8BF4", VA = "0x1BB8BF4")]
	private void AddPendingNotificationToQueue(PendingNotification notification)
	{
	}

	[Token(Token = "0x600F460")]
	[Address(RVA = "0x1BB5CE4", Offset = "0x1BB5CE4", VA = "0x1BB5CE4")]
	private PendingNotification GetPendingNotificationFromPool()
	{
		return null;
	}

	[Token(Token = "0x600F461")]
	[Address(RVA = "0x1BB8AD4", Offset = "0x1BB8AD4", VA = "0x1BB8AD4")]
	private uint CheckWeaponSkinId(uint skinId)
	{
		return default(uint);
	}

	[Token(Token = "0x600F462")]
	[Address(RVA = "0x1BB8CF8", Offset = "0x1BB8CF8", VA = "0x1BB8CF8", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600F463")]
	[Address(RVA = "0x1BB466C", Offset = "0x1BB466C", VA = "0x1BB466C")]
	private void UpdateMiniTips(bool isMini)
	{
	}

	[Token(Token = "0x600F464")]
	[Address(RVA = "0x1BB8E9C", Offset = "0x1BB8E9C", VA = "0x1BB8E9C")]
	private void OnIngameTipsChanged(object[] data)
	{
	}

	[Token(Token = "0x600F465")]
	[Address(RVA = "0x1BB8F90", Offset = "0x1BB8F90", VA = "0x1BB8F90")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F466")]
	[Address(RVA = "0x1BB8F98", Offset = "0x1BB8F98", VA = "0x1BB8F98")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F467")]
	[Address(RVA = "0x1BB8FA0", Offset = "0x1BB8FA0", VA = "0x1BB8FA0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
