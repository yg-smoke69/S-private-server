using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003BC5")]
public class RCC_WheelCollider : MonoBehaviour, _Attribute
{
	[Token(Token = "0x4019799")]
	[FieldOffset(Offset = "0xC")]
	public RCC_CarControllerV3 carController;

	[Token(Token = "0x401979A")]
	[FieldOffset(Offset = "0x10")]
	public bool fixWheelOverlap;

	[Token(Token = "0x401979B")]
	[FieldOffset(Offset = "0x14")]
	private Rigidbody rigid;

	[Token(Token = "0x401979C")]
	[FieldOffset(Offset = "0x18")]
	private WheelCollider _wheelCollider;

	[Token(Token = "0x401979D")]
	[FieldOffset(Offset = "0x1C")]
	private List<RCC_WheelCollider> allWheelColliders;

	[Token(Token = "0x401979E")]
	[FieldOffset(Offset = "0x20")]
	public Transform wheelModel;

	[NonSerialized]
	[Token(Token = "0x401979F")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 WheelModelOffset;

	[Token(Token = "0x40197A0")]
	[FieldOffset(Offset = "0x30")]
	private Transform WheelModelRotation;

	[Token(Token = "0x40197A1")]
	[FieldOffset(Offset = "0x34")]
	private float wheelRotation;

	[Token(Token = "0x40197A2")]
	[FieldOffset(Offset = "0x38")]
	private float camber;

	[Token(Token = "0x40197A3")]
	[FieldOffset(Offset = "0x3C")]
	internal float steerAngle;

	[Token(Token = "0x40197A4")]
	[FieldOffset(Offset = "0x40")]
	internal bool isGrounded;

	[Token(Token = "0x40197A5")]
	[FieldOffset(Offset = "0x44")]
	internal float totalSlip;

	[Token(Token = "0x40197A6")]
	[FieldOffset(Offset = "0x48")]
	internal float rpm;

	[Token(Token = "0x40197A7")]
	[FieldOffset(Offset = "0x4C")]
	internal float wheelRPMToSpeed;

	[Token(Token = "0x40197A8")]
	[FieldOffset(Offset = "0x50")]
	private float wheelSlipAmountSideways;

	[Token(Token = "0x40197A9")]
	[FieldOffset(Offset = "0x54")]
	private float wheelSlipAmountForward;

	[Token(Token = "0x40197AA")]
	[FieldOffset(Offset = "0x58")]
	private float orgSidewaysStiffness;

	[Token(Token = "0x40197AB")]
	[FieldOffset(Offset = "0x5C")]
	private float orgForwardStiffness;

	[Token(Token = "0x40197AC")]
	[FieldOffset(Offset = "0x60")]
	public WheelFrictionCurve forwardFrictionCurve;

	[Token(Token = "0x40197AD")]
	[FieldOffset(Offset = "0x74")]
	public WheelFrictionCurve sidewaysFrictionCurve;

	[Token(Token = "0x40197AE")]
	[FieldOffset(Offset = "0x88")]
	internal float tractionHelpedSidewaysStiffness;

	[Token(Token = "0x40197AF")]
	[FieldOffset(Offset = "0x8C")]
	private float minForwardStiffness;

	[Token(Token = "0x40197B0")]
	[FieldOffset(Offset = "0x90")]
	private float maxForwardStiffness;

	[Token(Token = "0x40197B1")]
	[FieldOffset(Offset = "0x94")]
	private float minSidewaysStiffness;

	[Token(Token = "0x40197B2")]
	[FieldOffset(Offset = "0x98")]
	private float maxSidewaysStiffness;

	[Token(Token = "0x40197B3")]
	[FieldOffset(Offset = "0x9C")]
	public float ForwardSlip;

	[Token(Token = "0x40197B4")]
	[FieldOffset(Offset = "0xA0")]
	public LayerMask ColliderMask;

	[Token(Token = "0x40197B5")]
	[FieldOffset(Offset = "0xA4")]
	internal bool disableModelTransUpdate;

	[Token(Token = "0x40197B6")]
	[FieldOffset(Offset = "0xA8")]
	private float m_ScaleY;

	[Token(Token = "0x40197B7")]
	[FieldOffset(Offset = "0xAC")]
	private float mOrgRadius;

	[Token(Token = "0x40197B8")]
	[FieldOffset(Offset = "0xB0")]
	public int raysNumber;

	[Token(Token = "0x40197B9")]
	[FieldOffset(Offset = "0xB4")]
	public float rayStartAngle;

	[Token(Token = "0x40197BA")]
	[FieldOffset(Offset = "0xB8")]
	public float raysMaxAngle;

	[Token(Token = "0x40197BB")]
	[FieldOffset(Offset = "0xBC")]
	public float wheelWidth;

	[Token(Token = "0x40197BC")]
	[FieldOffset(Offset = "0xC0")]
	public float wheelColliderMaxScale;

	[Token(Token = "0x40197BD")]
	[FieldOffset(Offset = "0xC4")]
	public bool doWheelAlign;

	[Token(Token = "0x170018DC")]
	public WheelCollider wheelCollider
	{
		[Token(Token = "0x6017D8C")]
		[Address(RVA = "0x1E3AA00", Offset = "0x1E3AA00", VA = "0x1E3AA00")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017D8D")]
		[Address(RVA = "0x1E3D4F0", Offset = "0x1E3D4F0", VA = "0x1E3D4F0")]
		set
		{
		}
	}

	[Token(Token = "0x170018DD")]
	public bool IsGrounded
	{
		[Token(Token = "0x6017D8E")]
		[Address(RVA = "0x1E34A90", Offset = "0x1E34A90", VA = "0x1E34A90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018DE")]
	public float motorTorque
	{
		[Token(Token = "0x6017D90")]
		[Address(RVA = "0x1E3D5C4", Offset = "0x1E3D5C4", VA = "0x1E3D5C4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6017D8F")]
		[Address(RVA = "0x1E3D4F8", Offset = "0x1E3D4F8", VA = "0x1E3D4F8")]
		set
		{
		}
	}

	[Token(Token = "0x170018DF")]
	public float brakeTorque
	{
		[Token(Token = "0x6017D92")]
		[Address(RVA = "0x1E3D758", Offset = "0x1E3D758", VA = "0x1E3D758")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6017D91")]
		[Address(RVA = "0x1E3D68C", Offset = "0x1E3D68C", VA = "0x1E3D68C")]
		set
		{
		}
	}

	[Token(Token = "0x6017D8B")]
	[Address(RVA = "0x1E3D3B0", Offset = "0x1E3D3B0", VA = "0x1E3D3B0")]
	public RCC_WheelCollider()
	{
	}

	[Token(Token = "0x6017D93")]
	[Address(RVA = "0x1E3D820", Offset = "0x1E3D820", VA = "0x1E3D820")]
	private void Awake()
	{
	}

	[Token(Token = "0x6017D94")]
	[Address(RVA = "0x1E3DD68", Offset = "0x1E3DD68", VA = "0x1E3DD68")]
	private void Start()
	{
	}

	[Token(Token = "0x6017D95")]
	[Address(RVA = "0x1E3DE14", Offset = "0x1E3DE14", VA = "0x1E3DE14")]
	private void Update()
	{
	}

	[Token(Token = "0x6017D96")]
	[Address(RVA = "0x1E3ECBC", Offset = "0x1E3ECBC", VA = "0x1E3ECBC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6017D97")]
	[Address(RVA = "0x1E3ECFC", Offset = "0x1E3ECFC", VA = "0x1E3ECFC")]
	public void UpdateWheelCollider()
	{
	}

	[Token(Token = "0x6017D98")]
	[Address(RVA = "0x1E3F250", Offset = "0x1E3F250", VA = "0x1E3F250")]
	private void FixWheelOverlap()
	{
	}

	[Token(Token = "0x6017D99")]
	[Address(RVA = "0x1E3DCE4", Offset = "0x1E3DCE4", VA = "0x1E3DCE4")]
	private WheelFrictionCurve SetFrictionCurves(WheelFrictionCurve curve, float extremumSlip, float extremumValue, float asymptoteSlip, float asymptoteValue)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(WheelFrictionCurve);
	}

	[Token(Token = "0x6017D9A")]
	[Address(RVA = "0x1E3E158", Offset = "0x1E3E158", VA = "0x1E3E158")]
	public void WheelAlign()
	{
	}

	[Token(Token = "0x6017D9B")]
	[Address(RVA = "0x1E3EA14", Offset = "0x1E3EA14", VA = "0x1E3EA14")]
	public void WheelCamber()
	{
	}

	[Token(Token = "0x6017D9C")]
	[Address(RVA = "0x1E3F0C8", Offset = "0x1E3F0C8", VA = "0x1E3F0C8")]
	private void Frictions(bool contacted, float forwardSlip)
	{
	}

	[Token(Token = "0x6017D9D")]
	[Address(RVA = "0x1E3F948", Offset = "0x1E3F948", VA = "0x1E3F948")]
	private void Drift(float forwardSlip)
	{
	}

	[Token(Token = "0x6017D9E")]
	[Address(RVA = "0x1E3FE48", Offset = "0x1E3FE48", VA = "0x1E3FE48")]
	private bool isSkidding()
	{
		return default(bool);
	}

	[Token(Token = "0x6017D9F")]
	[Address(RVA = "0x1E3518C", Offset = "0x1E3518C", VA = "0x1E3518C")]
	public void EnableWheelCollider(bool e)
	{
	}

	[Token(Token = "0x6017DA0")]
	[Address(RVA = "0x1E3BD80", Offset = "0x1E3BD80", VA = "0x1E3BD80", Slot = "4")]
	public void AttachWheelModel(Transform model)
	{
	}
}
