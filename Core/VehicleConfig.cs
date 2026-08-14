using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D16")]
public class VehicleConfig : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000D17")]
	public class CarCrashParam
	{
		[Token(Token = "0x4006A23")]
		[FieldOffset(Offset = "0x8")]
		public float messFactor;

		[Token(Token = "0x4006A24")]
		[FieldOffset(Offset = "0xC")]
		public float maxSpeed;

		[Token(Token = "0x4006A25")]
		[FieldOffset(Offset = "0x10")]
		public float minDamage;

		[Token(Token = "0x4006A26")]
		[FieldOffset(Offset = "0x14")]
		public float maxDamage;

		[Token(Token = "0x600644D")]
		[Address(RVA = "0x2A69280", Offset = "0x2A69280", VA = "0x2A69280")]
		public CarCrashParam()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000D18")]
	public class CarExplodeParam
	{
		[Token(Token = "0x4006A27")]
		[FieldOffset(Offset = "0x8")]
		public float ExplodeDelay;

		[Token(Token = "0x4006A28")]
		[FieldOffset(Offset = "0xC")]
		public float ExplodeRange;

		[Token(Token = "0x4006A29")]
		[FieldOffset(Offset = "0x10")]
		public uint ExplodeDamage;

		[Token(Token = "0x4006A2A")]
		[FieldOffset(Offset = "0x14")]
		public float BurnTime;

		[Token(Token = "0x4006A2B")]
		[FieldOffset(Offset = "0x18")]
		public BoxCollider BurnRange;

		[Token(Token = "0x4006A2C")]
		[FieldOffset(Offset = "0x1C")]
		public uint BurnDamage;

		[Token(Token = "0x4006A2D")]
		[FieldOffset(Offset = "0x20")]
		public float BurnInterval;

		[Token(Token = "0x600644E")]
		[Address(RVA = "0x2A69288", Offset = "0x2A69288", VA = "0x2A69288")]
		public CarExplodeParam()
		{
		}
	}

	[Token(Token = "0x4006A1F")]
	[FieldOffset(Offset = "0xC")]
	public EControlMode conrolMode;

	[Token(Token = "0x4006A20")]
	[FieldOffset(Offset = "0x10")]
	public CarCrashParam crashParam;

	[Token(Token = "0x4006A21")]
	[FieldOffset(Offset = "0x14")]
	public CarExplodeParam ExplodeParam;

	[Token(Token = "0x4006A22")]
	[FieldOffset(Offset = "0x18")]
	public CarInWaterParam InWaterParam;

	[Token(Token = "0x600644C")]
	[Address(RVA = "0x2A69278", Offset = "0x2A69278", VA = "0x2A69278")]
	public VehicleConfig()
	{
	}
}
