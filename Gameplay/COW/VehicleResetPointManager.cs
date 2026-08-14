using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A9F")]
public class VehicleResetPointManager : MonoBehaviour
{
	[Token(Token = "0x4005CFB")]
	[FieldOffset(Offset = "0xC")]
	public List<VehicleResetPos> VehicleResetPos;

	[Token(Token = "0x4005CFC")]
	[FieldOffset(Offset = "0x10")]
	public GameObject NextEffectGo;

	[Token(Token = "0x4005CFD")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ArrowGo;

	[Token(Token = "0x4005CFE")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<VehicleResetPos> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600515F")]
	[Address(RVA = "0x219B96C", Offset = "0x219B96C", VA = "0x219B96C")]
	public VehicleResetPointManager()
	{
	}

	[Token(Token = "0x6005160")]
	[Address(RVA = "0x219B974", Offset = "0x219B974", VA = "0x219B974")]
	private void Start()
	{
	}

	[Token(Token = "0x6005161")]
	[Address(RVA = "0x219BBD4", Offset = "0x219BBD4", VA = "0x219BBD4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005162")]
	[Address(RVA = "0x219BE34", Offset = "0x219BE34", VA = "0x219BE34")]
	private void OnLocalPlayerAdd(object[] data)
	{
	}

	[Token(Token = "0x6005163")]
	[Address(RVA = "0x219C074", Offset = "0x219C074", VA = "0x219C074")]
	private void OnMiniGameClose(object[] data)
	{
	}

	[Token(Token = "0x6005164")]
	[Address(RVA = "0x219C228", Offset = "0x219C228", VA = "0x219C228")]
	private void OnMiniGameStart(object[] data)
	{
	}

	[Token(Token = "0x6005165")]
	[Address(RVA = "0x219C350", Offset = "0x219C350", VA = "0x219C350")]
	private void OnVehicleReachPoint(object[] data)
	{
	}

	[Token(Token = "0x6005166")]
	[Address(RVA = "0x219C770", Offset = "0x219C770", VA = "0x219C770")]
	private static int _003COnLocalPlayerAdd_003Em__0(VehicleResetPos x, VehicleResetPos y)
	{
		return default(int);
	}
}
