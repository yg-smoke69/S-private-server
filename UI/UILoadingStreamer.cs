using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using WorldStreamer;

[Token(Token = "0x2003D41")]
public class UILoadingStreamer : MonoBehaviour
{
	[Token(Token = "0x2003D42")]
	private sealed class _003CTurnOff_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4019FD4")]
		[FieldOffset(Offset = "0x8")]
		internal UILoadingStreamer _0024this;

		[Token(Token = "0x4019FD5")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4019FD6")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4019FD7")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170019ED")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6018821")]
			[Address(RVA = "0x1488EEC", Offset = "0x1488EEC", VA = "0x1488EEC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170019EE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6018822")]
			[Address(RVA = "0x1488EF4", Offset = "0x1488EF4", VA = "0x1488EF4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601881F")]
		[Address(RVA = "0x1488D54", Offset = "0x1488D54", VA = "0x1488D54")]
		public _003CTurnOff_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6018820")]
		[Address(RVA = "0x1488DC0", Offset = "0x1488DC0", VA = "0x1488DC0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6018823")]
		[Address(RVA = "0x1488EFC", Offset = "0x1488EFC", VA = "0x1488EFC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6018824")]
		[Address(RVA = "0x1488F10", Offset = "0x1488F10", VA = "0x1488F10", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4019FD0")]
	[FieldOffset(Offset = "0xC")]
	public Streamer[] streamers;

	[Token(Token = "0x4019FD1")]
	[FieldOffset(Offset = "0x10")]
	public UISprite progressImg;

	[Token(Token = "0x4019FD2")]
	[FieldOffset(Offset = "0x14")]
	public float waitTime;

	[Token(Token = "0x4019FD3")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent onDone;

	[Token(Token = "0x601881A")]
	[Address(RVA = "0x1488964", Offset = "0x1488964", VA = "0x1488964")]
	public UILoadingStreamer()
	{
	}

	[Token(Token = "0x601881B")]
	[Address(RVA = "0x1488974", Offset = "0x1488974", VA = "0x1488974")]
	private void Awake()
	{
	}

	[Token(Token = "0x601881C")]
	[Address(RVA = "0x1488A2C", Offset = "0x1488A2C", VA = "0x1488A2C")]
	private void Update()
	{
	}

	[Token(Token = "0x601881D")]
	[Address(RVA = "0x1488CD0", Offset = "0x1488CD0", VA = "0x1488CD0")]
	public IEnumerator TurnOff()
	{
		return null;
	}

	[Token(Token = "0x601881E")]
	[Address(RVA = "0x1488D5C", Offset = "0x1488D5C", VA = "0x1488D5C")]
	public void Show()
	{
	}
}
