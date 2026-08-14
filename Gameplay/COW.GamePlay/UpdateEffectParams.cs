using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x2000D23")]
public class UpdateEffectParams
{
	[Token(Token = "0x4006A64")]
	[FieldOffset(Offset = "0x8")]
	public GameObject GameObject;

	[Token(Token = "0x4006A65")]
	[FieldOffset(Offset = "0xC")]
	public ParticleSystem Effect;

	[Token(Token = "0x4006A66")]
	[FieldOffset(Offset = "0x10")]
	public bool UpdateStartSize;

	[Token(Token = "0x4006A67")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 MinSpeedStartSize;

	[Token(Token = "0x4006A68")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 MaxSpeedStartSize;

	[Token(Token = "0x4006A69")]
	[FieldOffset(Offset = "0x24")]
	public bool UpdateRotationBySpeed;

	[Token(Token = "0x4006A6A")]
	[FieldOffset(Offset = "0x28")]
	public float MinSpeedVelocity;

	[Token(Token = "0x4006A6B")]
	[FieldOffset(Offset = "0x2C")]
	public float MaxSpeedVelocity;

	[Token(Token = "0x4006A6C")]
	[FieldOffset(Offset = "0x30")]
	public bool UpdateVelocityX;

	[Token(Token = "0x4006A6D")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 MinSpeedVelocityX;

	[Token(Token = "0x4006A6E")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 MaxSpeedVelocityX;

	[Token(Token = "0x6006478")]
	[Address(RVA = "0xF8C610", Offset = "0xF8C610", VA = "0xF8C610")]
	public UpdateEffectParams()
	{
	}

	[Token(Token = "0x6006479")]
	[Address(RVA = "0xF8C618", Offset = "0xF8C618", VA = "0xF8C618")]
	public void FHIPMICEPMI(float BLHEBBCODLC)
	{
	}
}
