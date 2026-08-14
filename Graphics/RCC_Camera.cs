using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003BB8")]
public class RCC_Camera : MonoBehaviour
{
	[Token(Token = "0x2003BB9")]
	public enum CameraMode
	{
		[Token(Token = "0x40196BA")]
		TPS,
		[Token(Token = "0x40196BB")]
		FPS,
		[Token(Token = "0x40196BC")]
		WHEEL,
		[Token(Token = "0x40196BD")]
		FIXED
	}

	[Token(Token = "0x2003BBA")]
	private sealed class _003CFixShakeDelayed_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x40196BE")]
		[FieldOffset(Offset = "0x8")]
		internal RCC_Camera _0024this;

		[Token(Token = "0x40196BF")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x40196C0")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x40196C1")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170018C2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6017D2A")]
			[Address(RVA = "0x1E33E58", Offset = "0x1E33E58", VA = "0x1E33E58", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170018C3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6017D2B")]
			[Address(RVA = "0x1E33E60", Offset = "0x1E33E60", VA = "0x1E33E60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6017D28")]
		[Address(RVA = "0x1E33BE8", Offset = "0x1E33BE8", VA = "0x1E33BE8")]
		public _003CFixShakeDelayed_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6017D29")]
		[Address(RVA = "0x1E33BF0", Offset = "0x1E33BF0", VA = "0x1E33BF0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6017D2C")]
		[Address(RVA = "0x1E33E68", Offset = "0x1E33E68", VA = "0x1E33E68", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6017D2D")]
		[Address(RVA = "0x1E33E7C", Offset = "0x1E33E7C", VA = "0x1E33E7C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40196A1")]
	[FieldOffset(Offset = "0xC")]
	public Transform playerCar;

	[Token(Token = "0x40196A2")]
	[FieldOffset(Offset = "0x10")]
	private Rigidbody playerRigid;

	[Token(Token = "0x40196A3")]
	[FieldOffset(Offset = "0x14")]
	private Camera cam;

	[Token(Token = "0x40196A4")]
	[FieldOffset(Offset = "0x18")]
	public GameObject pivot;

	[Token(Token = "0x40196A5")]
	[FieldOffset(Offset = "0x1C")]
	private GameObject boundCenter;

	[Token(Token = "0x40196A6")]
	[FieldOffset(Offset = "0x20")]
	public CameraMode cameraMode;

	[Token(Token = "0x40196A7")]
	[FieldOffset(Offset = "0x24")]
	public float distance;

	[Token(Token = "0x40196A8")]
	[FieldOffset(Offset = "0x28")]
	public float height;

	[Token(Token = "0x40196A9")]
	[FieldOffset(Offset = "0x2C")]
	private float heightDamping;

	[Token(Token = "0x40196AA")]
	[FieldOffset(Offset = "0x30")]
	private float rotationDamping;

	[Token(Token = "0x40196AB")]
	[FieldOffset(Offset = "0x34")]
	public float targetFieldOfView;

	[Token(Token = "0x40196AC")]
	[FieldOffset(Offset = "0x38")]
	public float minimumFOV;

	[Token(Token = "0x40196AD")]
	[FieldOffset(Offset = "0x3C")]
	public float maximumFOV;

	[Token(Token = "0x40196AE")]
	[FieldOffset(Offset = "0x40")]
	public float hoodCameraFOV;

	[Token(Token = "0x40196AF")]
	[FieldOffset(Offset = "0x44")]
	public float wheelCameraFOV;

	[Token(Token = "0x40196B0")]
	[FieldOffset(Offset = "0x48")]
	public float maximumTilt;

	[Token(Token = "0x40196B1")]
	[FieldOffset(Offset = "0x4C")]
	private float tiltAngle;

	[Token(Token = "0x40196B2")]
	[FieldOffset(Offset = "0x50")]
	internal int cameraSwitchCount;

	[Token(Token = "0x40196B3")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 targetPosition;

	[Token(Token = "0x40196B4")]
	[FieldOffset(Offset = "0x60")]
	private float speed;

	[Token(Token = "0x40196B5")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 localVector;

	[Token(Token = "0x40196B6")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 collisionPos;

	[Token(Token = "0x40196B7")]
	[FieldOffset(Offset = "0x7C")]
	private Quaternion collisionRot;

	[Token(Token = "0x40196B8")]
	[FieldOffset(Offset = "0x8C")]
	private float index;

	[Token(Token = "0x170018C1")]
	public Transform _playerCar
	{
		[Token(Token = "0x6017D1D")]
		[Address(RVA = "0x1E31F10", Offset = "0x1E31F10", VA = "0x1E31F10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017D1E")]
		[Address(RVA = "0x1E31F18", Offset = "0x1E31F18", VA = "0x1E31F18")]
		set
		{
		}
	}

	[Token(Token = "0x6017D1C")]
	[Address(RVA = "0x1E31E10", Offset = "0x1E31E10", VA = "0x1E31E10")]
	public RCC_Camera()
	{
	}

	[Token(Token = "0x6017D1F")]
	[Address(RVA = "0x1E32224", Offset = "0x1E32224", VA = "0x1E32224")]
	private void Awake()
	{
	}

	[Token(Token = "0x6017D20")]
	[Address(RVA = "0x1E31F20", Offset = "0x1E31F20", VA = "0x1E31F20")]
	private void GetPlayerCar()
	{
	}

	[Token(Token = "0x6017D21")]
	[Address(RVA = "0x1E3236C", Offset = "0x1E3236C", VA = "0x1E3236C")]
	public void SetPlayerCar(GameObject player)
	{
	}

	[Token(Token = "0x6017D22")]
	[Address(RVA = "0x1E323A8", Offset = "0x1E323A8", VA = "0x1E323A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6017D23")]
	[Address(RVA = "0x1E3262C", Offset = "0x1E3262C", VA = "0x1E3262C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6017D24")]
	[Address(RVA = "0x1E32754", Offset = "0x1E32754", VA = "0x1E32754")]
	private void TPS()
	{
	}

	[Token(Token = "0x6017D25")]
	[Address(RVA = "0x1E33564", Offset = "0x1E33564", VA = "0x1E33564")]
	public void Collision(Collision collision)
	{
	}

	[Token(Token = "0x6017D26")]
	[Address(RVA = "0x1E33AFC", Offset = "0x1E33AFC", VA = "0x1E33AFC")]
	public void FixShake()
	{
	}

	[Token(Token = "0x6017D27")]
	[Address(RVA = "0x1E33B64", Offset = "0x1E33B64", VA = "0x1E33B64")]
	private IEnumerator FixShakeDelayed()
	{
		return null;
	}
}
