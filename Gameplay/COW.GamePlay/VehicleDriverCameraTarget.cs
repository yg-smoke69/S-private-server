using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000D1B")]
internal class VehicleDriverCameraTarget : CameraTrackableEntityBase, _Attribute, IConvertible, IComparable<int>
{
	[Token(Token = "0x4006A2E")]
	[FieldOffset(Offset = "0x10")]
	public float TargetCameraDistance;

	[Token(Token = "0x4006A2F")]
	[FieldOffset(Offset = "0x14")]
	public float TargetCameraHeight;

	[Token(Token = "0x4006A30")]
	[FieldOffset(Offset = "0x18")]
	public float CameraMinPitch;

	[Token(Token = "0x4006A31")]
	[FieldOffset(Offset = "0x1C")]
	public float CameraMaxPitch;

	[Token(Token = "0x4006A32")]
	[FieldOffset(Offset = "0x20")]
	public bool DetailedCollisionChecks;

	[Token(Token = "0x4006A33")]
	[FieldOffset(Offset = "0x21")]
	public bool KeepInitialHeight;

	[Token(Token = "0x4006A34")]
	[FieldOffset(Offset = "0x24")]
	public IJOMOIINJGM VelocityEntity;

	[Token(Token = "0x17000878")]
	public Transform LAINHEIINKN
	{
		[Token(Token = "0x6006454")]
		[Address(RVA = "0x26EB760", Offset = "0x26EB760", VA = "0x26EB760", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006451")]
	[Address(RVA = "0x26EB470", Offset = "0x26EB470", VA = "0x26EB470")]
	public VehicleDriverCameraTarget()
	{
	}

	[Token(Token = "0x6006452")]
	[Address(RVA = "0x26EB4A0", Offset = "0x26EB4A0", VA = "0x26EB4A0")]
	public void SetupCamera(VehicleDriverCamera KFGFLKFGPBA)
	{
	}

	[Token(Token = "0x6006453")]
	[Address(RVA = "0x26EB5C8", Offset = "0x26EB5C8", VA = "0x26EB5C8", Slot = "10")]
	public Vector3 GetVelocity()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}
}
