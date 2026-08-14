using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000742")]
public class PreparePhaseCameraPivot : MonoBehaviour, _Attribute
{
	[Token(Token = "0x4004CD3")]
	[FieldOffset(Offset = "0xC")]
	private Transform m_CachTransform;

	[Token(Token = "0x6002DDD")]
	[Address(RVA = "0x1E2F570", Offset = "0x1E2F570", VA = "0x1E2F570")]
	public PreparePhaseCameraPivot()
	{
	}

	[Token(Token = "0x6002DDE")]
	[Address(RVA = "0x1E2F578", Offset = "0x1E2F578", VA = "0x1E2F578")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002DDF")]
	[Address(RVA = "0x1E2F61C", Offset = "0x1E2F61C", VA = "0x1E2F61C", Slot = "4")]
	public Vector3 GetCameraTrackableEntityPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002DE0")]
	[Address(RVA = "0x1E2F650", Offset = "0x1E2F650", VA = "0x1E2F650", Slot = "5")]
	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002DE1")]
	[Address(RVA = "0x1E2F684", Offset = "0x1E2F684", VA = "0x1E2F684", Slot = "6")]
	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x6002DE2")]
	[Address(RVA = "0x1E2F6B8", Offset = "0x1E2F6B8", VA = "0x1E2F6B8", Slot = "7")]
	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	[Token(Token = "0x6002DE3")]
	[Address(RVA = "0x1E2F6C0", Offset = "0x1E2F6C0", VA = "0x1E2F6C0", Slot = "8")]
	public bool IsCameraTrackableEntityAlive()
	{
		return default(bool);
	}
}
