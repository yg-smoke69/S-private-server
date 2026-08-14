using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026C0")]
public class UIGyroCameraController : MonoBehaviour
{
	[Token(Token = "0x20026C1")]
	private sealed class _003CStayCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400EF2C")]
		[FieldOffset(Offset = "0x8")]
		internal UIGyroCameraController _0024this;

		[Token(Token = "0x400EF2D")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400EF2E")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400EF2F")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011A0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600EA1F")]
			[Address(RVA = "0x202A0A4", Offset = "0x202A0A4", VA = "0x202A0A4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011A1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600EA20")]
			[Address(RVA = "0x202A0AC", Offset = "0x202A0AC", VA = "0x202A0AC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600EA1D")]
		[Address(RVA = "0x2029D58", Offset = "0x2029D58", VA = "0x2029D58")]
		public _003CStayCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600EA1E")]
		[Address(RVA = "0x2029FA4", Offset = "0x2029FA4", VA = "0x2029FA4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600EA21")]
		[Address(RVA = "0x202A0B4", Offset = "0x202A0B4", VA = "0x202A0B4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600EA22")]
		[Address(RVA = "0x202A0C8", Offset = "0x202A0C8", VA = "0x202A0C8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400EF24")]
	[FieldOffset(Offset = "0xC")]
	public float restoreSpeed;

	[Token(Token = "0x400EF25")]
	[FieldOffset(Offset = "0x10")]
	public float moveSpeed;

	[Token(Token = "0x400EF26")]
	[FieldOffset(Offset = "0x14")]
	public float stayTime;

	[Token(Token = "0x400EF27")]
	[FieldOffset(Offset = "0x18")]
	private float nextStayTime;

	[Token(Token = "0x400EF28")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 startRotation;

	[Token(Token = "0x400EF29")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 rotateOffset;

	[Token(Token = "0x400EF2A")]
	[FieldOffset(Offset = "0x34")]
	private bool isRestoring;

	[Token(Token = "0x400EF2B")]
	[FieldOffset(Offset = "0x35")]
	private bool isStaying;

	[Token(Token = "0x600EA16")]
	[Address(RVA = "0x2029624", Offset = "0x2029624", VA = "0x2029624")]
	public UIGyroCameraController()
	{
	}

	[Token(Token = "0x600EA17")]
	[Address(RVA = "0x202964C", Offset = "0x202964C", VA = "0x202964C")]
	private void Start()
	{
	}

	[Token(Token = "0x600EA18")]
	[Address(RVA = "0x2029740", Offset = "0x2029740", VA = "0x2029740")]
	private void Update()
	{
	}

	[Token(Token = "0x600EA19")]
	[Address(RVA = "0x2029C8C", Offset = "0x2029C8C", VA = "0x2029C8C")]
	private IEnumerator StayCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600EA1A")]
	[Address(RVA = "0x2029D60", Offset = "0x2029D60", VA = "0x2029D60")]
	public void SetGyroSwitch(bool ison)
	{
	}

	[Token(Token = "0x600EA1B")]
	[Address(RVA = "0x2029B7C", Offset = "0x2029B7C", VA = "0x2029B7C")]
	private Vector3 GetRotateOffset(Vector3 rotationRate, Vector3 userAcceleration, float deltaTime)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EA1C")]
	[Address(RVA = "0x2029EF4", Offset = "0x2029EF4", VA = "0x2029EF4")]
	private float GetRealAngle(float velocity, float acceleration, float deltaTime)
	{
		return default(float);
	}
}
