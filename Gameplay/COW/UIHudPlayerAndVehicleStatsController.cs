using System.Collections.Generic;
using COW.GamePlay;
using COW.HUD;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027FE")]
internal class UIHudPlayerAndVehicleStatsController : UIBaseController
{
	[Token(Token = "0x400F6C5")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPlayerAndVehicleStatsView m_View;

	[Token(Token = "0x400F6C6")]
	[FieldOffset(Offset = "0x30")]
	private IHAAMHPPLMG m_BindPlayer;

	[Token(Token = "0x400F6C7")]
	[FieldOffset(Offset = "0x48")]
	private uint m_BindVehicleShieldId;

	[Token(Token = "0x400F6C8")]
	[FieldOffset(Offset = "0x4C")]
	private Player m_Player;

	[Token(Token = "0x400F6C9")]
	[FieldOffset(Offset = "0x50")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400F6CA")]
	[FieldOffset(Offset = "0x54")]
	private uint m_UpdateCallID;

	[Token(Token = "0x400F6CB")]
	[FieldOffset(Offset = "0x58")]
	private List<UIHudVehicleBufferController> m_BufferCtrls;

	[Token(Token = "0x400F6CC")]
	[FieldOffset(Offset = "0x5C")]
	public readonly float ColorPlayerStatsAlpha;

	[Token(Token = "0x400F6CD")]
	[FieldOffset(Offset = "0x60")]
	public readonly Color ColorDisableEquipmentStat;

	[Token(Token = "0x400F6CE")]
	[FieldOffset(Offset = "0x70")]
	public readonly Vector3 VehicleHPBarThumbOffset;

	[Token(Token = "0x600F876")]
	[Address(RVA = "0x185CB48", Offset = "0x185CB48", VA = "0x185CB48")]
	public UIHudPlayerAndVehicleStatsController()
	{
	}

	[Token(Token = "0x600F877")]
	[Address(RVA = "0x185CCC4", Offset = "0x185CCC4", VA = "0x185CCC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F878")]
	[Address(RVA = "0x185CD68", Offset = "0x185CD68", VA = "0x185CD68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F879")]
	[Address(RVA = "0x185CF20", Offset = "0x185CF20", VA = "0x185CF20", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F87A")]
	[Address(RVA = "0x185D5AC", Offset = "0x185D5AC", VA = "0x185D5AC")]
	private void OnLocalVehicleUseSkillItem(object[] data)
	{
	}

	[Token(Token = "0x600F87B")]
	[Address(RVA = "0x185D8E4", Offset = "0x185D8E4", VA = "0x185D8E4")]
	private void OnLocalVehicleGetBuff(object[] data)
	{
	}

	[Token(Token = "0x600F87C")]
	[Address(RVA = "0x185DC1C", Offset = "0x185DC1C", VA = "0x185DC1C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F87D")]
	[Address(RVA = "0x185E250", Offset = "0x185E250", VA = "0x185E250")]
	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	[Token(Token = "0x600F87E")]
	[Address(RVA = "0x185E8E8", Offset = "0x185E8E8", VA = "0x185E8E8")]
	public void BindPlayer(IHAAMHPPLMG pID)
	{
	}

	[Token(Token = "0x600F87F")]
	[Address(RVA = "0x185EBC0", Offset = "0x185EBC0", VA = "0x185EBC0")]
	private void OnPlayerPostInit(object[] data)
	{
	}

	[Token(Token = "0x600F880")]
	[Address(RVA = "0x185FD30", Offset = "0x185FD30", VA = "0x185FD30")]
	private void OnHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600F881")]
	[Address(RVA = "0x185FF4C", Offset = "0x185FF4C", VA = "0x185FF4C")]
	private void OnVehicleShieldHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600F882")]
	[Address(RVA = "0x1860150", Offset = "0x1860150", VA = "0x1860150")]
	private void OnGetOnVehicle(object[] data)
	{
	}

	[Token(Token = "0x600F883")]
	[Address(RVA = "0x185EDD8", Offset = "0x185EDD8", VA = "0x185EDD8")]
	private void RefreshHP(bool isDead)
	{
	}

	[Token(Token = "0x600F884")]
	[Address(RVA = "0x185F184", Offset = "0x185F184", VA = "0x185F184")]
	private void RefreshVehicleShieldHP(uint shieldHP)
	{
	}

	[Token(Token = "0x600F885")]
	[Address(RVA = "0x186065C", Offset = "0x186065C", VA = "0x186065C")]
	private void OnAddPlayer(object[] data)
	{
	}

	[Token(Token = "0x600F886")]
	[Address(RVA = "0x18607C4", Offset = "0x18607C4", VA = "0x18607C4")]
	private void OnObservePlayer(object[] data)
	{
	}

	[Token(Token = "0x600F887")]
	[Address(RVA = "0x1860DD0", Offset = "0x1860DD0", VA = "0x1860DD0")]
	private void OnRemoveMapMark(object[] data)
	{
	}

	[Token(Token = "0x600F888")]
	[Address(RVA = "0x1861008", Offset = "0x1861008", VA = "0x1861008")]
	private void OnUpdateMapMark(object[] data)
	{
	}

	[Token(Token = "0x600F889")]
	[Address(RVA = "0x185F658", Offset = "0x185F658", VA = "0x185F658")]
	private void RefreshSkillStatus()
	{
	}

	[Token(Token = "0x600F88A")]
	[Address(RVA = "0x18612B8", Offset = "0x18612B8", VA = "0x18612B8")]
	private void OnVehicleEquipmentChanged(object[] data)
	{
	}

	[Token(Token = "0x600F88B")]
	[Address(RVA = "0x1860B3C", Offset = "0x1860B3C", VA = "0x1860B3C")]
	private void RefreshVehicleEquipmentStats()
	{
	}

	[Token(Token = "0x600F88C")]
	[Address(RVA = "0x1860600", Offset = "0x1860600", VA = "0x1860600")]
	private void RefreshVehicleEquipmentStats(LevelVehicle veh)
	{
	}

	[Token(Token = "0x600F88D")]
	[Address(RVA = "0x1861434", Offset = "0x1861434", VA = "0x1861434")]
	private void ShowVehicleEqipIcon(UISprite s, bool show)
	{
	}

	[Token(Token = "0x600F88E")]
	[Address(RVA = "0x185E558", Offset = "0x185E558", VA = "0x185E558")]
	private void UpdateBufferView()
	{
	}

	[Token(Token = "0x600F88F")]
	[Address(RVA = "0x18614EC", Offset = "0x18614EC", VA = "0x18614EC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F890")]
	[Address(RVA = "0x18614F4", Offset = "0x18614F4", VA = "0x18614F4")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F891")]
	[Address(RVA = "0x18614FC", Offset = "0x18614FC", VA = "0x18614FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
