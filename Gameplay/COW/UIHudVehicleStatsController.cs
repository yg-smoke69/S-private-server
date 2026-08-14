using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028B3")]
public class UIHudVehicleStatsController : UIBaseController
{
	[Token(Token = "0x400FA62")]
	[FieldOffset(Offset = "0x28")]
	private UIHudVehicleStatsView m_View;

	[Token(Token = "0x400FA63")]
	[FieldOffset(Offset = "0x2C")]
	private Vehicle m_Vehicle;

	[Token(Token = "0x400FA64")]
	private const int SPEED_SAMPLE_COUNT = 10;

	[Token(Token = "0x400FA65")]
	[FieldOffset(Offset = "0x30")]
	private float m_SpeedSum;

	[Token(Token = "0x400FA66")]
	[FieldOffset(Offset = "0x34")]
	private Queue<float> m_Speeds;

	[Token(Token = "0x400FA67")]
	[FieldOffset(Offset = "0x38")]
	private StringBuilder mLabelBuilder;

	[Token(Token = "0x400FA68")]
	[FieldOffset(Offset = "0x3C")]
	private int mLastSpeed;

	[Token(Token = "0x400FA69")]
	[FieldOffset(Offset = "0x40")]
	private float eulerPerKm;

	[Token(Token = "0x400FA6A")]
	[FieldOffset(Offset = "0x44")]
	private float zRotation;

	[Token(Token = "0x400FA6B")]
	[FieldOffset(Offset = "0x48")]
	private List<GameObject> m_Upgrades;

	[Token(Token = "0x400FA6C")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_InitPosition;

	[Token(Token = "0x400FA6D")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 m_SpeedModeDriverPosition;

	[Token(Token = "0x600FFE7")]
	[Address(RVA = "0x1A7109C", Offset = "0x1A7109C", VA = "0x1A7109C")]
	public UIHudVehicleStatsController()
	{
	}

	[Token(Token = "0x600FFE8")]
	[Address(RVA = "0x1A71268", Offset = "0x1A71268", VA = "0x1A71268")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FFE9")]
	[Address(RVA = "0x1A7130C", Offset = "0x1A7130C", VA = "0x1A7130C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FFEA")]
	[Address(RVA = "0x1A71438", Offset = "0x1A71438", VA = "0x1A71438", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FFEB")]
	[Address(RVA = "0x1A71A54", Offset = "0x1A71A54", VA = "0x1A71A54", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FFEC")]
	[Address(RVA = "0x1A71DA8", Offset = "0x1A71DA8", VA = "0x1A71DA8")]
	private void OnHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600FFED")]
	[Address(RVA = "0x1A722B0", Offset = "0x1A722B0", VA = "0x1A722B0")]
	private void OnGetOn(object[] data)
	{
	}

	[Token(Token = "0x600FFEE")]
	[Address(RVA = "0x1A72664", Offset = "0x1A72664", VA = "0x1A72664")]
	private void Update()
	{
	}

	[Token(Token = "0x600FFEF")]
	[Address(RVA = "0x1A72760", Offset = "0x1A72760", VA = "0x1A72760")]
	private void UpdateSpeed()
	{
	}

	[Token(Token = "0x600FFF0")]
	[Address(RVA = "0x1A72A4C", Offset = "0x1A72A4C", VA = "0x1A72A4C")]
	private void UpdateSpeedPointer(int speed)
	{
	}

	[Token(Token = "0x600FFF1")]
	[Address(RVA = "0x1A71FF0", Offset = "0x1A71FF0", VA = "0x1A71FF0")]
	private void RefreshHP()
	{
	}

	[Token(Token = "0x600FFF2")]
	[Address(RVA = "0x1A72BCC", Offset = "0x1A72BCC", VA = "0x1A72BCC")]
	private void OnLocalVehcleLevelUp(object[] data)
	{
	}

	[Token(Token = "0x600FFF3")]
	[Address(RVA = "0x1A72D78", Offset = "0x1A72D78", VA = "0x1A72D78")]
	private void OnVehicleEquipmentChanged(object[] data)
	{
	}

	[Token(Token = "0x600FFF4")]
	[Address(RVA = "0x1A72EF4", Offset = "0x1A72EF4", VA = "0x1A72EF4")]
	private void RefreshVehicleEquipmentStats(LevelVehicle veh)
	{
	}

	[Token(Token = "0x600FFF5")]
	[Address(RVA = "0x1A73148", Offset = "0x1A73148", VA = "0x1A73148")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FFF6")]
	[Address(RVA = "0x1A73150", Offset = "0x1A73150", VA = "0x1A73150")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600FFF7")]
	[Address(RVA = "0x1A73158", Offset = "0x1A73158", VA = "0x1A73158")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
