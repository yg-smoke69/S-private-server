using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026C2")]
public class UIGyroPositionController : MonoBehaviour
{
	[Token(Token = "0x20026C3")]
	private sealed class _003CStayCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400EF38")]
		[FieldOffset(Offset = "0x8")]
		internal UIGyroPositionController _0024this;

		[Token(Token = "0x400EF39")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400EF3A")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400EF3B")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011A2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600EA2F")]
			[Address(RVA = "0x202ABF8", Offset = "0x202ABF8", VA = "0x202ABF8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011A3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600EA30")]
			[Address(RVA = "0x202AC00", Offset = "0x202AC00", VA = "0x202AC00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600EA2D")]
		[Address(RVA = "0x202AA40", Offset = "0x202AA40", VA = "0x202AA40")]
		public _003CStayCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600EA2E")]
		[Address(RVA = "0x202AAF8", Offset = "0x202AAF8", VA = "0x202AAF8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600EA31")]
		[Address(RVA = "0x202AC08", Offset = "0x202AC08", VA = "0x202AC08", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600EA32")]
		[Address(RVA = "0x202AC1C", Offset = "0x202AC1C", VA = "0x202AC1C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400EF30")]
	[FieldOffset(Offset = "0xC")]
	public float restoreSpeed;

	[Token(Token = "0x400EF31")]
	[FieldOffset(Offset = "0x10")]
	public float moveSpeed;

	[Token(Token = "0x400EF32")]
	[FieldOffset(Offset = "0x14")]
	public float stayTime;

	[Token(Token = "0x400EF33")]
	[FieldOffset(Offset = "0x18")]
	private float nextStayTime;

	[Token(Token = "0x400EF34")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 startPosition;

	[Token(Token = "0x400EF35")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 positionOffset;

	[Token(Token = "0x400EF36")]
	[FieldOffset(Offset = "0x34")]
	private bool isRestoring;

	[Token(Token = "0x400EF37")]
	[FieldOffset(Offset = "0x35")]
	private bool isStaying;

	[Token(Token = "0x600EA23")]
	[Address(RVA = "0x202A150", Offset = "0x202A150", VA = "0x202A150")]
	public UIGyroPositionController()
	{
	}

	[Token(Token = "0x600EA24")]
	[Address(RVA = "0x202A178", Offset = "0x202A178", VA = "0x202A178")]
	public void SetRestoreTime(string text)
	{
	}

	[Token(Token = "0x600EA25")]
	[Address(RVA = "0x202A1E8", Offset = "0x202A1E8", VA = "0x202A1E8")]
	public void SetMoveSpeed(string text)
	{
	}

	[Token(Token = "0x600EA26")]
	[Address(RVA = "0x202A258", Offset = "0x202A258", VA = "0x202A258")]
	public void SetStayTime(string text)
	{
	}

	[Token(Token = "0x600EA27")]
	[Address(RVA = "0x202A2C8", Offset = "0x202A2C8", VA = "0x202A2C8")]
	private void Start()
	{
	}

	[Token(Token = "0x600EA28")]
	[Address(RVA = "0x202A4B4", Offset = "0x202A4B4", VA = "0x202A4B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600EA29")]
	[Address(RVA = "0x202A974", Offset = "0x202A974", VA = "0x202A974")]
	private IEnumerator StayCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600EA2A")]
	[Address(RVA = "0x202A3A4", Offset = "0x202A3A4", VA = "0x202A3A4")]
	public void SetGyroSwitch(bool ison)
	{
	}

	[Token(Token = "0x600EA2B")]
	[Address(RVA = "0x202A864", Offset = "0x202A864", VA = "0x202A864")]
	private Vector3 GetRotateOffset(Vector3 rotationRate, Vector3 userAcceleration, float deltaTime)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EA2C")]
	[Address(RVA = "0x202AA48", Offset = "0x202AA48", VA = "0x202AA48")]
	private float GetRealAngle(float velocity, float acceleration, float deltaTime)
	{
		return default(float);
	}
}
