using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20007A7")]
internal class AirTransporter : Entity, _Attribute
{
	[Token(Token = "0x4004EFC")]
	[FieldOffset(Offset = "0x34")]
	public Transform m_PassengerContainer;

	[Token(Token = "0x4004EFD")]
	[FieldOffset(Offset = "0x38")]
	public Transform[] m_FlightPos;

	[Token(Token = "0x4004EFE")]
	[FieldOffset(Offset = "0x3C")]
	public Transform m_Model;

	[Token(Token = "0x4004EFF")]
	[FieldOffset(Offset = "0x40")]
	public bool UseAnimationA;

	[Token(Token = "0x4004F00")]
	[FieldOffset(Offset = "0x44")]
	private AirtransportParams IOMEBNMHCIK;

	[Token(Token = "0x4004F01")]
	[FieldOffset(Offset = "0x48")]
	private float PIOHCJGJHFP;

	[Token(Token = "0x4004F02")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 HLFILLDFDND;

	[Token(Token = "0x4004F03")]
	[FieldOffset(Offset = "0x58")]
	private GameObject NJNEBPNALAM;

	[Token(Token = "0x4004F04")]
	[FieldOffset(Offset = "0x5C")]
	private uint PLKMJOGOJKM;

	[Token(Token = "0x4004F05")]
	[FieldOffset(Offset = "0x60")]
	private Transform KMBCOJEBOMI;

	[Token(Token = "0x4004F06")]
	[FieldOffset(Offset = "0x64")]
	private PostEffectManager NAMHPFBOFDP;

	[Token(Token = "0x4004F07")]
	[FieldOffset(Offset = "0x0")]
	private static Action HMDOHFBHDOB;

	[Token(Token = "0x60030BC")]
	[Address(RVA = "0x11374C4", Offset = "0x11374C4", VA = "0x11374C4")]
	public AirTransporter()
	{
	}

	[Token(Token = "0x60030BD")]
	[Address(RVA = "0x1137548", Offset = "0x1137548", VA = "0x1137548", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60030BE")]
	[Address(RVA = "0x1137670", Offset = "0x1137670", VA = "0x1137670", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x60030BF")]
	[Address(RVA = "0x1137798", Offset = "0x1137798", VA = "0x1137798", Slot = "24")]
	public Vector3 GetCameraTrackableEntityPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60030C0")]
	[Address(RVA = "0x11378D0", Offset = "0x11378D0", VA = "0x11378D0", Slot = "25")]
	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60030C1")]
	[Address(RVA = "0x1137960", Offset = "0x1137960", VA = "0x1137960", Slot = "26")]
	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x60030C2")]
	[Address(RVA = "0x11379F0", Offset = "0x11379F0", VA = "0x11379F0", Slot = "27")]
	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	[Token(Token = "0x60030C3")]
	[Address(RVA = "0x1137A54", Offset = "0x1137A54", VA = "0x1137A54", Slot = "28")]
	public bool IsCameraTrackableEntityAlive()
	{
		return default(bool);
	}

	[Token(Token = "0x60030C4")]
	[Address(RVA = "0x1137AAC", Offset = "0x1137AAC", VA = "0x1137AAC")]
	public void SelectAirline(AirtransportParams AEKOCMIGJBA)
	{
	}

	[Token(Token = "0x60030C5")]
	[Address(RVA = "0x1137E38", Offset = "0x1137E38", VA = "0x1137E38")]
	public void SetOnBoard(Transform PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x60030C6")]
	[Address(RVA = "0x1137FC8", Offset = "0x1137FC8", VA = "0x1137FC8")]
	public void SetOnBoard(Player PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x60030C7")]
	[Address(RVA = "0x11383A4", Offset = "0x11383A4", VA = "0x11383A4")]
	public void SetOffBoard(Transform PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x60030C8")]
	[Address(RVA = "0x1138454", Offset = "0x1138454", VA = "0x1138454")]
	public void TryGetOffBoard(Transform PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x60030C9")]
	[Address(RVA = "0x1138564", Offset = "0x1138564", VA = "0x1138564", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60030CA")]
	[Address(RVA = "0x113893C", Offset = "0x113893C", VA = "0x113893C")]
	public Vector3 GetMovingVector()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60030CB")]
	[Address(RVA = "0x11389AC", Offset = "0x11389AC", VA = "0x11389AC")]
	public bool IsForceToJump(IHAAMHPPLMG BECFAIOFONM)
	{
		return default(bool);
	}

	[Token(Token = "0x60030CC")]
	[Address(RVA = "0x1138DD4", Offset = "0x1138DD4", VA = "0x1138DD4")]
	public bool CanJump()
	{
		return default(bool);
	}

	[Token(Token = "0x60030CD")]
	[Address(RVA = "0x1138EF0", Offset = "0x1138EF0", VA = "0x1138EF0")]
	public bool CanJump(float LGHNJEDOFFD)
	{
		return default(bool);
	}

	[Token(Token = "0x60030CE")]
	[Address(RVA = "0x1138F6C", Offset = "0x1138F6C", VA = "0x1138F6C")]
	public AirtransportParams GetParam()
	{
		return null;
	}

	[Token(Token = "0x60030CF")]
	[Address(RVA = "0x1138FC4", Offset = "0x1138FC4", VA = "0x1138FC4")]
	public void OnOpeningStart()
	{
	}

	[Token(Token = "0x60030D0")]
	[Address(RVA = "0x113975C", Offset = "0x113975C", VA = "0x113975C")]
	public void OnOpeningEnd(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x60030D1")]
	[Address(RVA = "0x1139564", Offset = "0x1139564", VA = "0x1139564")]
	private void HCHAKGKNJKM(bool MCDIDHODHLN)
	{
	}

	[Token(Token = "0x60030D2")]
	[Address(RVA = "0x1139A58", Offset = "0x1139A58", VA = "0x1139A58")]
	private static void FKNDHONIIHB()
	{
	}

	[Token(Token = "0x60030D3")]
	[Address(RVA = "0x1139AF4", Offset = "0x1139AF4", VA = "0x1139AF4")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x60030D4")]
	[Address(RVA = "0x1139AFC", Offset = "0x1139AFC", VA = "0x1139AFC")]
	public void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x60030D5")]
	[Address(RVA = "0x1139B04", Offset = "0x1139B04", VA = "0x1139B04")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
