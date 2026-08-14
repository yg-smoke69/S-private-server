using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000CF6")]
public class CameraTrackableEntityBase : MonoBehaviour, _Attribute
{
	[Token(Token = "0x40068D5")]
	[FieldOffset(Offset = "0xC")]
	public float TopHeight;

	[Token(Token = "0x600622B")]
	[Address(RVA = "0x1E953E4", Offset = "0x1E953E4", VA = "0x1E953E4")]
	public CameraTrackableEntityBase()
	{
	}

	[Token(Token = "0x600622C")]
	[Address(RVA = "0x1E953F4", Offset = "0x1E953F4", VA = "0x1E953F4", Slot = "4")]
	public Vector3 GetCameraTrackableEntityPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600622D")]
	[Address(RVA = "0x1E95484", Offset = "0x1E95484", VA = "0x1E95484", Slot = "5")]
	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600622E")]
	[Address(RVA = "0x1E955DC", Offset = "0x1E955DC", VA = "0x1E955DC", Slot = "6")]
	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x600622F")]
	[Address(RVA = "0x1E956B0", Offset = "0x1E956B0", VA = "0x1E956B0", Slot = "7")]
	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	[Token(Token = "0x6006230")]
	[Address(RVA = "0x1E95714", Offset = "0x1E95714", VA = "0x1E95714", Slot = "8")]
	public bool IsCameraTrackableEntityAlive()
	{
		return default(bool);
	}
}
